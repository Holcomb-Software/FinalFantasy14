using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FinalFantasy14.Update;

public partial class Update : ContentPage, INotifyPropertyChanged
{
    private double _scriptProgress;
    private string _statusText = "Ready to start";
    private bool _isNotRunning = true;

    public double ScriptProgress
    {
        get => _scriptProgress;
        set { _scriptProgress = value; OnPropertyChanged(); }
    }

    public string StatusText
    {
        get => _statusText;
        set { _statusText = value; OnPropertyChanged(); }
    }

    public bool IsNotRunning
    {
        get => _isNotRunning;
        set { _isNotRunning = value; OnPropertyChanged(); }
    }

    public ICommand RunScriptCommand { get; set; }

    public Update()
    {
        InitializeComponent();
        BindingContext = this;
        RunScriptCommand = new Command(async () => await ExecuteScriptAsync());
    }

    private async Task ExecuteScriptAsync()
    {
        IsNotRunning = false;
        ScriptProgress = 0.0;

        // Resolve absolute directory path where application binaries/scripts reside
        string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string script1Path = Path.Combine(appDirectory, "armor_scraper.py");
        string script2Path = Path.Combine(appDirectory, "weapon_scraper.py");

        try
        {
            // --- STAGE 1: Execute First Python Script ---
            StatusText = "Running Script 1...";
            var progressScript1 = new Progress<double>(percent =>
            {
                ScriptProgress = percent * 0.5; // 0.0 -> 0.5
                StatusText = $"Script 1 in progress... {percent * 100:F0}%";
            });

            await Task.Run(() => RunPythonScript(script1Path, progressScript1));

            // --- STAGE 2: Execute Second Python Script ---
            StatusText = "Running Script 2...";
            var progressScript2 = new Progress<double>(percent =>
            {
                ScriptProgress = 0.5 + (percent * 0.5); // 0.5 -> 1.0
                StatusText = $"Script 2 in progress... {percent * 100:F0}%";
            });

            await Task.Run(() => RunPythonScript(script2Path, progressScript2));

            // --- Completion ---
            ScriptProgress = 1.0;
            StatusText = "Both scripts completed successfully!";
        }
        catch (Exception ex)
        {
            StatusText = $"Error: {ex.Message}";
        }
        finally
        {
            IsNotRunning = true;
        }
    }

    private void RunPythonScript(string scriptPath, IProgress<double> progress)
    {
        if (!File.Exists(scriptPath))
        {
            throw new FileNotFoundException($"Python script not found at: {scriptPath}");
        }

        var startInfo = new ProcessStartInfo
        {
            FileName = "python", // Uses 'python' or 'python3' on system PATH
            Arguments = $"\"{scriptPath}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = new Process { StartInfo = startInfo };

        process.Start();

        // Optional: Read standard output line-by-line if script prints progress (e.g., "PROGRESS:50")
        while (!process.StandardOutput.EndOfStream)
        {
            string line = process.StandardOutput.ReadLine();

            // If python outputs progress lines like "PROGRESS:0.5", parse and report it:
            if (line != null && line.StartsWith("PROGRESS:"))
            {
                if (double.TryParse(line.Replace("PROGRESS:", "").Trim(), out double parsedPercent))
                {
                    progress?.Report(parsedPercent);
                }
            }
        }

        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            string errorOutput = process.StandardError.ReadToEnd();
            throw new Exception($"Script exited with code {process.ExitCode}: {errorOutput}");
        }

        // Ensure stage reports 100% completion when finished
        progress?.Report(1.0);
    }

    public new event PropertyChangedEventHandler PropertyChanged;
    protected new void OnPropertyChanged([CallerMemberName] string name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}