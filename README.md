### 📄 **`README.md` – Portals Coding Challenges**  

# 🚀 PortalsCodingChallenges  
Welcome!
This is a .NET 8 solution designed for practicing coding challenges from various platforms using a TDD (Test-Driven Development) approach. This repository includes solutions for problems from platforms like **Beecrowd**, **HackerRank**, and **LeetCode**, with tests written in **MSTest**.  
Feel free for Contributing!
Everyone is Welcome!

---

## 📂 **Project Structure**  
```
📂 PortalsCodingChallenges/
│── 📂 PortalsCodingChallenges/        # Main Project (Solution Implementations)
│── 📂 PortalsCodingChallengesTests/   # Test Project (MSTest Framework)
│── 📂 .github/                        # GitHub Actions (CI)
│── 📄 PortalsCodingChallenges.sln     # Solution File
│── 📄 README.md                       # Project Documentation
│── 📄 .gitignore                      # Git Ignore Rules
```

---

## ⚙️ **Technology Stack**  
- **.NET 8.0**  
- **C#** (Object-Oriented Programming)  
- **MSTest** (Unit Testing)  
- **GitHub Actions** (CI/CD)  
- **TDD** (Test-Driven Development)  

---

## 🧪 **TDD Approach**  
This project follows the TDD methodology:  
1. 🟥 **Red:** Write a failing test.  
2. 🟩 **Green:** Implement the minimal code to pass the test.  
3. 🟦 **Refactor:** Improve the code without changing functionality.  

---

## 🚀 **Running Tests**  

### 1️⃣ **Restore Dependencies:**  
```bash
dotnet restore
```

### 2️⃣ **Build the Solution:**  
```bash
dotnet build
```

### 3️⃣ **Run Tests:**  
```bash
dotnet test
```

---

## 📂 **CI Configuration (`ci.yml`)**  
```yaml
name: Run Tests PortalsCodingChallenge

on:
  push:
    branches:
      - main
  pull_request:

jobs:
  build-and-test:
    runs-on: ubuntu-latest

    steps:
      - name: Checkout repository
        uses: actions/checkout@v3

      - name: Setup .NET 8
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: '8.0.x'

      - name: Restore dependencies
        run: dotnet restore

      - name: Build
        run: dotnet build --configuration Release --no-restore

      - name: Run Tests with Coverage
        run: dotnet test --configuration Release --no-restore --logger "console;verbosity=normal" --collect:"XPlat Code Coverage"

      - name: Upload Test Results
        uses: actions/upload-artifact@v3
        with:
          name: test-results
          path: '**/TestResults/*.trx'

      - name: Upload Coverage Report
        uses: actions/upload-artifact@v3
        with:
          name: coverage-results
          path: '**/TestResults/**/coverage.cobertura.xml'

    strategy:
      fail-fast: true

```

---

## 🧪 **First Challenge – Problem1000 (Beecrowd)**  
- **Description:** Print `Hello World!` to the console.  
- **Test Status:** 🟥 **RED** (Test created but not implemented)  

---

## 📌 **Initial Commit:**  
1. ✅ Created the project structure.  
2. ✅ Added the first test (`Problem1000Test.cs`) - Status: **RED**.  
3. ✅ Added `README.md` and `.gitignore` to the repository.  

---

## 📝 **First Commit Command:**  
```bash
git add .
git commit -m "chore: add README and first Problem1000 test (TDD - Red Phase)"
git push origin main
```

---

## 🎯 **Next Steps:**  
- 🟢 Implement `Problem1000` to pass the test (TDD - Green Phase).  
- 🟦 Refactor the code for clarity and performance.  
- 🧪 Add more coding challenges and their tests.  

---

## 💡 **Contributing:**  
Feel free to fork this repository and submit pull requests!  

---

## 📜 **License:**  
This project is licensed under the MIT License.  
