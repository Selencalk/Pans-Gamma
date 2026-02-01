# Object Oriented Programming

A collection of C# programs demonstrating object-oriented programming concepts: classes, inheritance, polymorphism, properties, delegates, and various algorithms.

## Contents

### Classes & Objects

| File | Description |
|------|-------------|
| `Employee.cs` | Basic employee class with name, position, salary, age; random age generation |
| `C# Employee.cs` | Inheritance: `Person` → `Employee` → `Boss`; static counter and list display |
| `Employee Interitance- Polymorphism.cs` | `Employee` and `Manager`; polymorphism via `SetRise()` override (Manager gets extra bonus) |
| `student.cs` | Student class with properties, validation, static counter, `FindBestStudent`; sorts by name and grade |
| `StudentInheritance.cs` | `Student` and `GraduateStudent`; virtual/override `IncreaseGrade`; inheritance and polymorphism |
| `StudentScholarshipCheck.cs` | Delegate example; `ScholarshipStatus` checks student marks against minimum score |

### Inheritance Examples

| File | Description |
|------|-------------|
| `InheritanceExample.cs` | `Computer` → `Server`, `GraphicsWorkstation`; `PowerOn`/`PowerOff`; type checks with `is` pattern |

### Computer & Network

| File | Description |
|------|-------------|
| `ComputerExample.cs` | Simple `Computer` class with BIOS name, IP address, and OS |
| `ComputerExample2.cs` | `Device` class; static counter, `AssignIP`, `RemoveDevice`; network list management |
| `Computer Properties.cs` | `Computer` with properties and static counter; network of 5 computers |

### Animals

| File | Description |
|------|-------------|
| `animalcost.cs` | `Animal` and `Species` (dogs/cats); `HowMuch()`; dogs have walk fees; LINQ filtering and aggregation |

### Algorithms & Math

| File | Description |
|------|-------------|
| `Fibonacci.cs` | Prints Fibonacci series; user specifies number of terms |
| `FactorialMethods.cs` | Factorial with both `for` and `while` loops |
| `PositiveNegativeSeries.cs` | Alternating series: 1, -2, 3, -4, … |
| `TriangleChecker.cs` | Validates triangle sides; checks right-angled triangle (Pythagorean theorem) |
| `Find The Guess Number.cs` | Binary search game; computer guesses number 1–1000 using `c`/`h`/`l` feedback |

### Pi Approximation

| File | Description |
|------|-------------|
| `Calculate Pi With Euler.cs` | Euler formula: √(6 × Σ 1/n²) |
| `Calculate Pi With Leibniz.cs` | Leibniz series: 4 × (1 - 1/3 + 1/5 - 1/7 + …) |
| `Calculate Pi With Wallis.cs` | Wallis product formula |
| `PiApproximation.cs` | All three methods plus iteration count for given tolerance |

### Visualization (Python)

| File | Description |
|------|-------------|
| `AverageTemperaturePlot.py` | Reads temperature CSV from web; plots average daily temperature (Death Valley 2018) with matplotlib and pandas |

## Running the Programs

### Prerequisites

- .NET SDK or Mono (for C#)
- Python 3.x with `pandas`, `matplotlib` (for `AverageTemperaturePlot.py`)

### C# — Compile and Run

```bash
# Single file
csc Fibonacci.cs
mono Fibonacci.exe

# Or with .NET
dotnet run
```

### Python — AverageTemperaturePlot

```bash
pip install pandas matplotlib
python AverageTemperaturePlot.py
```

### Namespaces

| Namespace | Files |
|-----------|-------|
| `OopInCsharp` | `Computer Properties.cs`, `C# Employee.cs` |
| `Csharpders` | `Employee Interitance- Polymorphism.cs`, `StudentInheritance.cs` |
| `AnimalExample` | `animalcost.cs` |
| `OOP_in_Csharp` | `ComputerExample.cs` |
| `OOP_Inheritance_Demo` | `InheritanceExample.cs` |
| `OOP_Device_Example` | `ComputerExample2.cs` |

## Concepts Covered

- **Classes & Objects** — Encapsulation, constructors, fields
- **Properties** — get/set, validation
- **Inheritance** — base class, derived class, `base()` constructor
- **Polymorphism** — `virtual`, `override`
- **Delegates** — `ScholarshipStatus` with lambda
- **Static Members** — counters, utility methods
- **Collections** — `List<T>`, LINQ
- **Pattern Matching** — `is` type check
- **Control Flow** — loops, conditionals, binary search
