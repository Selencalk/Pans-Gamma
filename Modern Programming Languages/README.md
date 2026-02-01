# Modern Programming Languages

A collection of Python programs demonstrating basic programming concepts, algorithms, data structures, and visualization.

## Contents

### Math & Algorithms

| File | Description |
|------|-------------|
| `Factorial.py` | Computes factorial using a `for` loop; prints `factorial(5)` |
| `Fibonacci.py` | Recursive Fibonacci function; prints `fibonacci(10)` |
| `Power.py` | Power function `a ** b`; prints `power(3, 8)` |
| `Total_calculation.py` | Sum of numbers 1–500 divisible by 4 or 7 |
| `SmallNumber.py` | Finds the smallest of three random numbers (1–1000) |
| `triangle_check.py` | Checks if three sides can form a valid triangle; returns `"possible"` or `"not possible"` |

### Lists & Loops

| File | Description |
|------|-------------|
| `Biggest Number.py` | Two-dice simulation: rolls 1M times; counts outcomes 2–12 and prints frequency |
| `dice_simulation.py` | Single-die simulation: 1M rolls; counts outcomes 1–6 |
| `Random Numbers.py` | Creates a list of 4 random integers (1–10), appends 10, computes and prints average |
| `list_traversal.py` | Traverses list `[10, 20, 30, 40]` forward and backward using indices |

### Text & Strings

| File | Description |
|------|-------------|
| `Char Counter.py` | Counts occurrences of a user-specified letter in a Polish city string; uses dictionary and `isalpha()` |
| `word_frequency.py` | Uses `Counter` from `collections` to find the most frequent word in user input |

### Visualization (Matplotlib)

| File | Description |
|------|-------------|
| `matplotlib_grafik.py` | Plots `f(x) = x² - 2` over [-5, 5]; saves as `f_plot.png` |
| `matplotlib_grafik2.py` | Plots `y = sin(x)/x` (sinc) over [-10, 10]; handles division by zero at x=0 |

### Unit Tests

| File | Description |
|------|-------------|
| `FactorialTest.py` | Unittest for `faktor.factorial` — expects `faktor` module |
| `FibonacciTest.py` | Unittest for `lib1.fibonacci` — expects `lib1` module |
| `PowerTest.py` | Unittest for `power.powerrr` — expects `power` module with `powerrr` function |

**Note:** Test files reference modules (`faktor`, `lib1`, `power.powerrr`) that may need to be created or renamed to match the main scripts (`Factorial`, `Fibonacci`, `Power`).

---

## File Summary (All 17 files)

| File | Purpose |
|------|---------|
| `Biggest Number.py` | Dice simulation (two dice, outcomes 2–12) |
| `Char Counter.py` | Letter count in a fixed string |
| `dice_simulation.py` | Single-die simulation (outcomes 1–6) |
| `Factorial.py` | Factorial calculation |
| `FactorialTest.py` | Unittest for factorial |
| `Fibonacci.py` | Recursive Fibonacci |
| `FibonacciTest.py` | Unittest for Fibonacci |
| `list_traversal.py` | Forward/backward list traversal |
| `matplotlib_grafik.py` | Plot `x² - 2` |
| `matplotlib_grafik2.py` | Plot `sin(x)/x` |
| `Power.py` | Power function |
| `PowerTest.py` | Unittest for power |
| `Random Numbers.py` | Random list and average |
| `SmallNumber.py` | Smallest of three random numbers |
| `Total_calculation.py` | Sum of numbers divisible by 4 or 7 |
| `triangle_check.py` | Triangle validity check |
| `word_frequency.py` | Most frequent word in text |

---

## Running the Programs

### Prerequisites

- Python 3.x
- For plotting: `numpy`, `matplotlib`

```bash
pip install numpy matplotlib
```

### Run a script

```bash
python "Biggest Number.py"
python Factorial.py
python Fibonacci.py
python Power.py
python SmallNumber.py
python "Total_calculation.py"
python list_traversal.py
python triangle_check.py
python "Char Counter.py"
python word_frequency.py
python "Random Numbers.py"
python dice_simulation.py
python matplotlib_grafik.py
python matplotlib_grafik2.py
```

### Run tests (after aligning module names)

```bash
python -m unittest FactorialTest
python -m unittest FibonacciTest
python -m unittest PowerTest
```

---

## Concepts Covered

- **Control flow** — `if`/`else`, `for`, `while`
- **Functions** — Definition, parameters, return values, recursion
- **Data structures** — Lists, dictionaries
- **Random** — `random.randint()`, simulations
- **Collections** — `Counter` from `collections`
- **Testing** — `unittest` framework
- **Plotting** — `matplotlib`, `numpy` for mathematical graphs
