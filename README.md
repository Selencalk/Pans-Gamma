# Pans-Gamma

A repository of educational projects covering different programming languages and concepts.

---

## Project Structure

### 1. Object Oriented Programming

Object-oriented programming examples using C#.

| File / Folder                           | Description                                     |
| --------------------------------------- | ----------------------------------------------- |
| `Employee.cs`                           | Employee class example                          |
| `C# Employee.cs`                        | Employee class implementation                   |
| `Employee Interitance- Polymorphism.cs` | Inheritance and polymorphism examples           |
| `StudentInheritance.cs`                 | Student inheritance example                     |
| `Computer Properties.cs`                | Computer properties class                       |
| `Calculate Pi With Euler.cs`            | Pi calculation using Euler's method             |
| `Calculate Pi With Wallis.cs`           | Pi calculation using Wallis' method             |
| `PiLeibniz.cs`                          | Pi calculation using Leibniz' method            |
| `Find The Guess Number.cs`              | Number guessing game                            |
| `main.cs`                               | Main program file                               |
| `student/`                              | Student class examples                          |
| `Animal/`                               | Animal class and AnimalRunDemo project (.NET 9) |

### 2. Modern Programming Languages

Basic programming and algorithm examples using Python.

| File                    | Description                        |
| ----------------------- | ---------------------------------- |
| `Biggest Number.py`     | Biggest number and dice simulation |
| `SmallNumber.py`        | Smallest number                    |
| `Char Counter.py`       | Character counter                  |
| `Random Numbers.py`     | Random number generation           |
| `dice_simulation.py`    | Dice simulation                    |
| `Fibonacci.py`          | Fibonacci sequence                 |
| `FibonacciTest.py`      | Fibonacci test                     |
| `Factorial.py`          | Factorial calculation              |
| `FactorialTest.py`      | Factorial test                     |
| `Power.py`              | Power calculation                  |
| `PowerTest.py`          | Power test                         |
| `Total_calculation.py`  | Total calculation                  |
| `list_traversal.py`     | List traversal                     |
| `triangle_check.py`     | Triangle check                     |
| `word_frequency.py`     | Word frequency                     |
| `matplotlib_grafik.py`  | Matplotlib graph example 1         |
| `matplotlib_grafik2.py` | Matplotlib graph example 2         |

### 3. Software Engineer

Web application built with Flask.

**Web Page** — Slider/carousel web application

- **Backend:** Flask (Python)
- **Frontend:** HTML5, CSS3, JavaScript
- **Features:** Auto slider (5s), keyboard and touch support, navigation dots

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
└── venv/               # Virtual environment
```

---

## Installation and Running

### Web application (Flask)

```bash
cd "Software Engineer/Web Page"
source venv/bin/activate
python3 app.py
```

Open in browser: **http://127.0.0.1:5000** or **http://localhost:5000**

### Python projects

```bash
cd "Modern Programming Languages"
python3 "Biggest Number.py"
```

### C# projects (mono)

```bash
cd " Object Oriented Programming"
mcs main.cs
mono main.exe
```

### Animal project (.NET)

```bash
cd " Object Oriented Programming/Animal/runproj"
dotnet run
```

---

## Web Application Usage

| Control               | Action                           |
| --------------------- | -------------------------------- |
| `→` / `↓`             | Next slide                       |
| `←` / `↑`             | Previous slide                   |
| `Space`               | Toggle auto slider on/off        |
| Mouse hover on slider | Auto transition pauses           |
| Bottom dots           | Direct slide selection           |
| Mobile                | Swipe left/right to change slide |

---

## Notes

- Flask is used for the web application; required packages are installed in the virtual environment.
- All projects are for educational purposes.

---

_Project structure and contents are subject to ongoing updates._
