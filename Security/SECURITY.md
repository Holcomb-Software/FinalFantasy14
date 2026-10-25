# Security Policy

## Supported Versions

We actively maintain and provide security updates for the following versions of the project:

| Version | Supported          |
| ------- | ------------------ |
| Main    | :white_check_mark: |
| < 1.0   | :x:                |

---

## Reporting a Vulnerability

We take the security of our application and data seriously. If you discover a security vulnerability, sensitive data exposure, or unsafe configuration, please let us know so we can address it promptly.

### How to Report
**Do not report security vulnerabilities through public GitHub issues, discussions, or pull requests.**

Instead, please report vulnerabilities by using one of the following methods:
* **Private Security Advisory:** Submit a report via GitHub’s [Private Vulnerability Reporting](https://docs.github.com/en/code-security/security-advisories/guidance-on-reporting-and-advising-on-vulnerabilities/privately-reporting-a-vulnerability) feature on this repository (Security tab -> Advisories -> Report a vulnerability).
* **Direct Email:** Reach out directly to the repository maintainer with details regarding the security issue.

### Information to Include
To help us triage and fix the issue quickly, please include:
1. A description of the vulnerability and its potential impact.
2. Steps to reproduce the issue (including any proof-of-concept code, HTTP requests, or app states).
3. The platform/device environment where the issue was discovered (e.g., Android, iOS, local build).

### Response & Resolution Timeline
* **Acknowledgement:** We aim to acknowledge receipt of your vulnerability report within **48 hours**.
* **Assessment & Fix:** We will evaluate the report, keep you updated on progress, and push a security fix or mitigation as soon as possible.

---

## Security Best Practices for Maintainers & Contributors

When working on or building this application, adhere to the following security guidelines:

### 1. API Keys & Secrets Management
* **Never commit secrets:** Never hardcode API keys, access tokens, database credentials, or secret keys into source code.
* **Environment Configuration:** Use local configuration files (`appsettings.json`, `.env`, or secure local storage) for tokens and keys. Ensure these files are listed in `.gitignore`.
* **Third-Party APIs:** Handle external game/market data APIs responsibly, ensuring endpoints are called securely over HTTPS and rate limits are respected.

### 2. Local Data Storage & Caching
* **Local Databases:** SQLite databases or cached game data stored on device should avoid holding unencrypted sensitive personal identifiers.
* **Secure Storage:** Store user tokens or app settings using platform-native secure storage APIs (such as SecureStorage / Keychain / Keystore).

### 3. Dependencies & Build Security
* **Dependency Scanning:** Dependabot alerts should be enabled for this repository to monitor and patch vulnerable libraries automatically.
* **Minimal Scope:** Keep third-party packages to a minimum and verify package authenticity before adding new dependencies.

---

## Intellectual Property & Game Assets
This project is an unofficial fan tool and is not affiliated with or endorsed by Square Enix. 
* All Final Fantasy XIV assets, data, and trademarks belong to **Square Enix Co., Ltd.**
* Ensure no proprietary binary game assets or copyrighted game code are directly checked into this repository.