# Web Page — Interactive Slider

A Flask web application featuring an interactive image slider (carousel) with automatic transitions, keyboard controls, and touch support.

## Technologies

- **Backend:** Flask (Python)
- **Frontend:** HTML5, CSS3, JavaScript
- **Structure:** Jinja2 templates, static assets

## Features

- **Automatic slider** — Slides change every 5 seconds
- **Keyboard navigation** — Arrow keys and Space to control slides
- **Mouse interaction** — Auto-slide pauses on hover, resumes on mouse leave
- **Touch/Swipe support** — Mobile-friendly; swipe left/right to change slides
- **Navigation dots** — Click dots at the bottom to jump to a slide

## File Structure

```
Web Page/
├── app.py              # Flask application
├── templates/
│   └── index.html      # Main page template
├── static/
│   ├── style.css       # Slider styling
│   ├── script.js       # Slider logic and interactions
│   └── images/         # Slide images
│       ├── slide1.jpg
│       ├── slide2.jpg
│       └── slide3.jpg
├── venv/               # Python virtual environment
└── README.md
```

## Setup and Run

### Prerequisites

- Python 3.x
- Flask

### Installation

1. Go to the project folder:
   ```bash
   cd "Software Engineer/Web Page"
   ```

2. Activate the virtual environment:
   ```bash
   source venv/bin/activate
   ```

3. If needed, install Flask:
   ```bash
   pip install flask
   ```

4. Run the app:
   ```bash
   python3 app.py
   ```

5. Open in browser:
   - `http://127.0.0.1:5000` or `http://localhost:5000`

## User Guide

### Keyboard

| Key | Action |
|-----|--------|
| `→` or `↓` | Next slide |
| `←` or `↑` | Previous slide |
| `Space` | Toggle automatic slider on/off |

### Mouse

- Hover over the slider to pause auto-slide
- Click the dots at the bottom to select a slide directly

### Mobile

- Swipe right → next slide
- Swipe left → previous slide

## Customization

- **Slides:** Add or replace images in `static/images/` and update `index.html` accordingly
- **Interval:** Change `autoSlideDelay` in `script.js` (default: 5000 ms)
