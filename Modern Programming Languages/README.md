# Modern Programming Languages

A collection of Python programs demonstrating basic programming concepts, algorithms, data structures, and visualization.

## Contents

### Math & Algorithms

| File | Description |
|------|-------------|
| `Factorial.py` | Computes factorial using a `for` loop |
| `Fibonacci.py` | Recursive Fibonacci function; prints `fibonacci(10)` |
| `Power.py` | Power function: `a ** b` |
| `Total_calculation.py` | Sum of numbers 1–500 divisible by 4 or 7 |
| `SmallNumber.py` | Finds the smallest of three random numbers |
| `triangle_check.py` | Checks if three sides can form a valid triangle |

### Lists & Loops

| File | Description |
|------|-------------|
| `Biggest Number.py` | Dice simulation: two dice rolled 1M times; counts outcomes (2–12) |
| `dice_simulation.py` | Single-die simulation: 1M rolls; counts outcomes 1–6 |
| `Random Numbers.py` | Generates random list, appends 10, computes average |
| `list_traversal.py` | Traverses a list forward and backward using indices |

### Text & Strings

| File | Description |
|------|-------------|
| `Char Counter.py` | Counts occurrences of a user-specified letter in a Polish city string |
| `word_frequency.py` | Uses `Counter` to find the most frequent word in user input |

### Visualization (Matplotlib)

| File | Description |
|------|-------------|
| `matplotlib_grafik.py` | Plots `f(x) = x² - 2`; saves as `f_plot.png` |
| `matplotlib_grafik2.py` | Plots `y = sin(x)/x` (sinc function); handles division by zero at x=0 |

### Unit Tests

| File | Description |
|------|-------------|
| `FactorialTest.py` | Unittest for `faktor.factorial` (expects `faktor` module) |
| `FibonacciTest.py` | Unittest for `lib1.fibonacci` (expects `lib1` module) |
| `PowerTest.py` | Unittest for `power.powerrr` (expects `power` module with `powerrr` function) |

**Note:** Test files reference modules (`faktor`, `lib1`, `power.powerrr`) that may need to be created or renamed to match the main scripts (`Factorial`, `Fibonacci`, `Power`).

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
python word_frequency.py
python matplotlib_grafik.py
```

### Run tests

```bash
# After aligning module names with test expectations:
python -m unittest FactorialTest
python -m unittest FibonacciTest
python -m unittest PowerTest
```

## Concepts Covered

- **Control flow** — `if`/`else`, `for`, `while`
- **Functions** — Definition, parameters, return values, recursion
- **Data structures** — Lists, dictionaries
- **Random** — `random.randint()`, simulations
- **Collections** — `Counter` from `collections`
- **Testing** — `unittest` framework
- **Plotting** — `matplotlib`, `numpy` for mathematical graphs
