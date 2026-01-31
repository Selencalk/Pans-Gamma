# Object Oriented Programming

A collection of C# programs demonstrating object-oriented programming concepts, including classes, inheritance, polymorphism, properties, and various algorithms.

## Contents

### Classes & Objects

| File | Description |
|------|-------------|
| `Employee.cs` | Basic employee class with name, position, salary, and age; uses random age generation |
| `C# Employee.cs` | Inheritance hierarchy: `Person` → `Employee` → `Boss` with static counter and list display |
| `Employee Interitance- Polymorphism.cs` | `Employee` and `Manager` classes; polymorphism via `SetRise()` override (Manager gets extra bonus) |
| `student.cs` | Student class with properties, validation, static counter, and `FindBestStudent`; sorts by name and grade |
| `StudentInheritance.cs` | `Student` and `GraduateStudent` with virtual/override `IncreaseGrade`; demonstrates inheritance and polymorphism |

### Computer & Network

| File | Description |
|------|-------------|
| `ComputerExample.cs` | Simple `Computer` class with BIOS name, IP address, and OS |
| `Computer Properties.cs` | `Computer` class with properties and static counter; creates a network of 5 computers using a list |

### Animals

| File | Description |
|------|-------------|
| `animalcost.cs` | `Animal` and `Species` (dogs/cats) with `HowMuch()`; dogs have walk fees; uses LINQ to filter and aggregate costs |

### Algorithms & Math

| File | Description |
|------|-------------|
| `Fibonacci.cs` | Prints Fibonacci series; user specifies the number of terms |
| `FactorialMethods.cs` | Factorial calculated with both `for` and `while` loops |
| `PositiveNegativeSeries.cs` | Alternating positive/negative series: 1, -2, 3, -4, … |
| `TriangleChecker.cs` | Validates triangle sides and checks for right-angled triangle (Pythagorean theorem) |
| `Find The Guess Number.cs` | Binary search: computer guesses your number (1–1000) using `c` / `h` / `l` feedback |

### Pi Approximation

| File | Description |
|------|-------------|
| `Calculate Pi With Euler.cs` | Pi using Euler’s formula: √(6 × Σ 1/n²) |
| `Calculate Pi With Leibniz.cs` | Pi using Leibniz series: 4 × (1 - 1/3 + 1/5 - 1/7 + …) |
| `Calculate Pi With Wallis.cs` | Pi using Wallis product formula |
| `PiApproximation.cs` | All three methods (Leibniz, Euler, Wallis) and iteration count for given tolerance |

## Running the Programs

### Prerequisites

- .NET SDK or Mono

### Compile and Run (single file)

```bash
# Example: Fibonacci
csc Fibonacci.cs
mono Fibonacci.exe

# Or with .NET Core
dotnet script Fibonacci.cs
```

### Namespaces

Some files use namespaces. If you combine them into one project, ensure namespaces match or adjust `using` statements accordingly.

| Namespace | Files |
|-----------|-------|
| `OopInCsharp` | `Computer Properties.cs`, `C# Employee.cs` |
| `Csharpders` | `Employee Interitance- Polymorphism.cs`, `StudentInheritance.cs` |
| `AnimalExample` | `animalcost.cs` |
| `OOP_in_Csharp` | `ComputerExample.cs` |

## Concepts Covered

- **Classes & Objects** — Encapsulation, constructors, fields
- **Properties** — get/set, validation
- **Inheritance** — base class, derived class, `base()` constructor
- **Polymorphism** — `virtual`, `override`
- **Static Members** — counters, utility methods
- **Collections** — `List<T>`, LINQ (`Where`, `OfType`, `Select`, `Sum`, `Average`)
- **Control Flow** — loops, conditionals, binary search
