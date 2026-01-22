

document.addEventListener('DOMContentLoaded', function() {
    const slides = document.querySelectorAll('input[name="slide"]');
    const totalSlides = slides.length;
    let currentSlide = 0;
    let autoSlideInterval;
    let isAutoSlideActive = true;
    const autoSlideDelay = 5000; 

    function getCurrentSlideIndex() {
        for (let i = 0; i < slides.length; i++) {
            if (slides[i].checked) {
                return i;
            }
        }
        return 0;
    }

    function goToSlide(index) {
        if (index >= 0 && index < totalSlides) {
            slides[index].checked = true;
            currentSlide = index;
            resetAutoSlide();
        }
    }

    function nextSlide() {
        currentSlide = getCurrentSlideIndex();
        const nextIndex = (currentSlide + 1) % totalSlides;
        goToSlide(nextIndex);
    }

    function prevSlide() {
        currentSlide = getCurrentSlideIndex();
        const prevIndex = (currentSlide - 1 + totalSlides) % totalSlides;
        goToSlide(prevIndex);
    }

    function startAutoSlide() {
        if (isAutoSlideActive) {
            autoSlideInterval = setInterval(nextSlide, autoSlideDelay);
        }
    }

    function stopAutoSlide() {
        clearInterval(autoSlideInterval);
    }

    function resetAutoSlide() {
        stopAutoSlide();
        if (isAutoSlideActive) {
            startAutoSlide();
        }
    }

    document.addEventListener('keydown', function(e) {
        if (e.key === 'ArrowRight' || e.key === 'ArrowDown') {
            e.preventDefault();
            nextSlide();
        } else if (e.key === 'ArrowLeft' || e.key === 'ArrowUp') {
            e.preventDefault();
            prevSlide();
        } else if (e.key === ' ') {
            e.preventDefault();
            isAutoSlideActive = !isAutoSlideActive;
            if (isAutoSlideActive) {
                startAutoSlide();
            } else {
                stopAutoSlide();
            }
        }
    });

    const slider = document.querySelector('.slider');
    if (slider) {
        slider.addEventListener('mouseenter', function() {
            stopAutoSlide();
        });

        slider.addEventListener('mouseleave', function() {
            if (isAutoSlideActive) {
                startAutoSlide();
            }
        });
    }

    const navLabels = document.querySelectorAll('.navigation label');
    navLabels.forEach((label, index) => {
        label.addEventListener('click', function() {
            goToSlide(index);
        });
    });

    let touchStartX = 0;
    let touchEndX = 0;

    if (slider) {
        slider.addEventListener('touchstart', function(e) {
            touchStartX = e.changedTouches[0].screenX;
        }, { passive: true });

        slider.addEventListener('touchend', function(e) {
            touchEndX = e.changedTouches[0].screenX;
            handleSwipe();
        }, { passive: true });
    }

    function handleSwipe() {
        const swipeThreshold = 50; 
        const diff = touchStartX - touchEndX;

        if (Math.abs(diff) > swipeThreshold) {
            if (diff > 0) {
                nextSlide();
            } else {
                prevSlide();
            }
        }
    }

    startAutoSlide();

    slides.forEach((slide, index) => {
        slide.addEventListener('change', function() {
            currentSlide = index;
            resetAutoSlide();
        });
    });

    console.log('Slider JavaScript yüklendi!');
    console.log('Kullanım:');
    console.log('- Ok tuşları ile navigasyon');
    console.log('- Space tuşu ile otomatik slider\'ı aç/kapat');
    console.log('- Mouse hover\'da otomatik slider durur');
    console.log('- Mobil cihazlarda swipe desteği');
});
