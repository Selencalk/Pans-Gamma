# Pans-Gamma Project

This repository contains educational projects covering different programming languages and concepts.

## 📁 Project Structure

### 1. Object Oriented Programming
Examples of object-oriented programming concepts using C# programming language.

**Contents:**
- `Employee.cs` - Employee class example
- `C# Employee.cs` - Employee class implementation
- `Employee Interitance- Polymorphism.cs` - Inheritance and polymorphism examples
- `Computer Properties.cs` - Computer properties class
- `Calculate Pi With Euler.cs` - Pi calculation using Euler's method
- `Calculate Pi With Wallis.cs` - Pi calculation using Wallis' method
- `Find The Guess Number.cs` - Number guessing game
- `main.cs` - Main program file
- `student/` - Student class examples

### 2. Modern Programming Languages
Basic programming concepts and algorithms using Python programming language.

**Contents:**
- `Biggest Number.py` - Finding the biggest number and dice simulation
- `Char Counter.py` - Character counting application
- `Random Numbers.py` - Random number generation
- `test_fibonacci.py` - Fibonacci sequence test
- `lib1.py` - Helper library functions

### 3. Software Engineer
Web application developed using Flask framework.

**Contents:**
- `Web Page/` - Interactive slider/carousel web application

#### Web Page Details

**Technologies:**
- **Backend:** Flask (Python)
- **Frontend:** HTML5, CSS3, JavaScript
- **Features:**
  - Automatic slider (transitions every 5 seconds)
  - Keyboard navigation (arrow keys, space key)
  - Mouse hover interaction
  - Touch/swipe support (mobile compatible)
  - Direct slide selection via navigation dots

**File Structure:**
```
Web Page/
├── app.py                 # Flask application file
├── templates/
│   └── index.html         # Main HTML template
├── static/
│   ├── style.css          # CSS styles
│   ├── script.js          # JavaScript functions
│   └── images/            # Slider images
│       ├── slide1.jpg
│       ├── slide2.jpg
│       └── slide3.jpg
└── venv/                  # Python virtual environment
```

## 🚀 Installation and Running

### Web Application (Flask)

1. **Activate Virtual Environment:**
   ```bash
   cd "Software Engineer/Web Page"
   source venv/bin/activate
   ```

2. **Run Flask Application:**
   ```bash
   python3 app.py
   ```

3. **Open in Browser:**
   - `http://127.0.0.1:5000` or `http://localhost:5000`

### Python Projects

You can run Python files directly:
```bash
cd "Modern Programming Languages"
python3 Biggest_Number.py
```

### C# Projects

To compile and run C# files:
```bash
cd "Object Oriented Programming"
mcs main.cs
mono main.exe
```

## 🎮 Web Application User Guide

### Keyboard Controls
- `→` or `↓` - Go to next slide
- `←` or `↑` - Go to previous slide
- `Space` - Toggle automatic slider on/off

### Mouse Controls
- Automatic transition pauses when hovering over the slider
- Automatic transition resumes when leaving the slider
- Click on the dots at the bottom for direct slide selection

### Mobile Devices
- Swipe right to go to next slide
- Swipe left to go to previous slide

## 📝 Notes

- Flask framework is used for the web application
- Required packages are installed in the virtual environment
- All projects are for educational purposes

## 👤 Developer

This project has been developed for educational purposes.

---

**Note:** Project structure and contents are continuously updated.
