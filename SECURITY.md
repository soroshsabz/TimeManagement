# Security Policy

## Supported Versions

As the **TimeManagement** project is in its early stages of active development, security updates and bug fixes are prioritized for the latest minor and patch releases. Older pre-releases or outdated patches are not actively maintained.

| Version   | Supported          | Notes                                     |
| --------- | ------------------ | ----------------------------------------- |
| 1.0.x     | :white_check_mark: | Currently supported with security updates |
| 0.1.x     | :white_check_mark: | Initial release / Active development      |
| < 0.1.0   | :x:                | Pre-release / Alpha builds not supported  |

> **Note:** We strongly recommend always running the latest available release to ensure you have the most up-to-date security patches.

---

## Reporting a Vulnerability

The TimeManagement team takes the security of our application and user data seriously. If you believe you have discovered a security vulnerability, please report it responsibly by following the guidelines below.

### 1. How to Report

**Please do NOT disclose vulnerabilities via public GitHub issues, discussions, or pull requests.**

Instead, report it using one of the following private channels:

- **GitHub Private Advisory (Preferred):**  
  Go to the repository's **Security** tab → **Advisories** → click **"Report a vulnerability"**.
- **Email:**  
  TODO: Send an email to `security@yourdomain.com` (or your project maintainer email: `maintainer-email@example.com`) with the subject line:  
  `[SECURITY] Vulnerability Report - TimeManagement`.

### 2. What to Include in Your Report

To help us triage and resolve the issue quickly, please provide:
- A clear description of the vulnerability and its potential impact.
- Step-by-step instructions to reproduce the issue (proof-of-concept script, payloads, or screenshots).
- The version of TimeManagement and the environment (OS, browser, runtime/database version) tested.
- Any known mitigations or remediation suggestions, if available.

### 3. Response & Resolution Process

Once a vulnerability report is submitted:

1. **Acknowledgment:** We will acknowledge receipt of your report within **48 hours**.
2. **Evaluation & Triage:** We will assess the report, verify the issue, and provide an initial status update within **3 to 5 business days**.
3. **Fix & Patch:** If confirmed, we will work on a patch in a private branch/advisory. We will keep you updated on progress.
4. **Public Disclosure:** Once a fix is released in a new patch version, a public security advisory will be published crediting your responsible disclosure (unless you prefer to remain anonymous).

---

## Scope & Safe Harbor

- We commit to not pursuing legal action against researchers who discover and report vulnerabilities in accordance with this policy and act in good faith.
- Please do not access, alter, or destroy user data, or conduct denial-of-service (DoS/DDoS) attacks against production infrastructure.
