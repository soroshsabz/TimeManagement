<center>ITNOA</center>

# ⏳ TimeManagement

[![Build Status](https://img.shields.io/badge/build-Cake-orange.svg)](build.cake)
[![Language](https://img.shields.io/badge/c%23-.NET-blue.svg)](https://dotnet.microsoft.com/)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

A modern, light, and efficient time management and task scheduling application built with C# and .NET.

---

## 📖 Overview

**TimeManagement** is designed to streamline day-to-day productivity by helping users organize activities, prioritize critical goals, and eliminate temporal friction. Built with clean C# architecture and a local-first philosophy, it provides a stable environment for personal and professional workflow management.

## ✨ Features

- **Task Scheduling & Allocation:** Organize tasks into dedicated time frames.
- **Priority Matrix:** Categorize activities based on urgency and importance.
- **Progress Tracking:** Clear view of completed milestones and daily habits.
- **Clean Architecture:** High performance with minimal resource consumption.

## 🛠 Tech Stack & Tools

- **Language:** C# / .NET
- **Build System:** [Cake (C# Make)](https://cakebuild.net/) for cross-platform task automation.
- **Testing:** Integrated unit testing via Cake build scripts.

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or later recommended)

### Installation & Build

Clone the repository:
```pwsh
git clone https://github.com/soroshsabz/TimeManagement.git
cd TimeManagement
```
Run the build script using Cake:
```pwsh
# Using the dotnet tool runner
dotnet cake

# Or using script bootsrappers (if present)
.\build.ps1     # Windows
```
### Running Tests

Cake automatically runs all test suites during the build step. To execute tests specifically:

```pwsh
dotnet cake --target=Test
```

## 🤝 Contributing

Contributions are welcome under the terms of the GPL!

1. Fork the project.
1. Create your feature branch (git checkout -b feature/NewFeature).
1. Commit your changes (git commit -m 'Add NewFeature').
1. Push to the branch (git push origin feature/NewFeature).
1. Open a Pull Request.

## 📄 License

Distributed under the GNU General Public License v3.0 (GPLv3). See LICENSE for details.
