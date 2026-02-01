# Pans-Gamma

A repository of educational projects covering different programming languages and concepts.

---

## Project Structure

### 1. [Object Oriented Programming]( Object Oriented Programming/README.md)

C# programs demonstrating OOP: classes, inheritance, polymorphism, delegates, and algorithms.

| Category | Contents |
|----------|----------|
| **Classes & Objects** | `Employee.cs`, `C# Employee.cs`, `Employee Interitance- Polymorphism.cs`, `student.cs`, `StudentInheritance.cs`, `StudentScholarshipCheck.cs` |
| **Inheritance** | `InheritanceExample.cs` — Computer → Server, GraphicsWorkstation |
| **Computer & Network** | `ComputerExample.cs`, `ComputerExample2.cs`, `Computer Properties.cs` |
| **Animals** | `animalcost.cs` — Animal/Species with LINQ |
| **Algorithms & Math** | `Fibonacci.cs`, `FactorialMethods.cs`, `PositiveNegativeSeries.cs`, `TriangleChecker.cs`, `Find The Guess Number.cs` |
| **Pi Approximation** | `Calculate Pi With Euler.cs`, `Calculate Pi With Leibniz.cs`, `Calculate Pi With Wallis.cs`, `PiApproximation.cs` |
| **Visualization** | `AverageTemperaturePlot.py` — Temperature plot (Python) |

See [Object Oriented Programming/README.md]( Object Oriented Programming/README.md) for full descriptions and run instructions.

---

### 2. [Modern Programming Languages](Modern%20Programming%20Languages/README.md)

Python programs for basic programming, algorithms, data structures, and visualization.

| Category | Contents |
|----------|----------|
| **Math & Algorithms** | `Factorial.py`, `Fibonacci.py`, `Power.py`, `Total_calculation.py`, `SmallNumber.py`, `triangle_check.py` |
| **Lists & Loops** | `Biggest Number.py`, `dice_simulation.py`, `Random Numbers.py`, `list_traversal.py` |
| **Text & Strings** | `Char Counter.py`, `word_frequency.py` |
| **Visualization** | `matplotlib_grafik.py`, `matplotlib_grafik2.py` |
| **Unit Tests** | `FactorialTest.py`, `FibonacciTest.py`, `PowerTest.py` |

See [Modern Programming Languages/README.md](Modern%20Programming%20Languages/README.md) for full descriptions and run instructions.

---

### 3. [Software Engineer — Web Page](Software%20Engineer/Web%20Page/README.md)

Flask web application with an interactive image slider (carousel).

| Technology | Details |
|------------|---------|
| **Backend** | Flask (Python) |
| **Frontend** | HTML5, CSS3, JavaScript |
| **Features** | Auto slider (5s), keyboard & touch support, navigation dots, mouse hover pause |

**File structure:**

```
Software Engineer/Web Page/
├── app.py              # Flask application
├── templates/
│   └── index.html      # Main template
├── static/
│   ├── style.css
│   ├── script.js
│   └── images/         # slide1.jpg, slide2.jpg, slide3.jpg
├── venv/               # Virtual environment
└── README.md
```

See [Software Engineer/Web Page/README.md](Software%20Engineer/Web%20Page/README.md) for setup, usage, and customization.

---

## Quick Start

### Web application (Flask)

```bash
cd "Software Engineer/Web Page"
source venv/bin/activate
python3 app.py
```

Open in browser: **http://127.0.0.1:5000** or **http://localhost:5000**

### Python projects (Modern Programming Languages)

```bash
cd "Modern Programming Languages"
python3 "Biggest Number.py"
python3 Factorial.py
# For plotting scripts:
pip install numpy matplotlib
```

### C# projects (Object Oriented Programming)

```bash
cd " Object Oriented Programming"
csc Fibonacci.cs
mono Fibonacci.exe
# Or with .NET:
dotnet run
```

---

## Web Application Controls

| Control | Action |
|---------|--------|
| `→` / `↓` | Next slide |
| `←` / `↑` | Previous slide |
| `Space` | Toggle auto slider on/off |
| Mouse hover on slider | Pause auto-slide |
| Bottom dots | Direct slide selection |
| Mobile | Swipe left/right to change slide |

---

## Notes

- Each subfolder has its own README with detailed documentation.
- Flask is used for the web application; packages are in the virtual environment.
- All projects are for educational purposes.

---

_Project structure and contents are subject to ongoing updates._
