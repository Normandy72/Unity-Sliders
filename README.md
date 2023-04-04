# Instructions

## Interactable Slider
1. Create a __Canvas__ (change a background color and add other elements you need).
2. Add a __Slider__ to the Canvas (you can check "Whole Numbers", change slider direction, min and max value, value at start as you need).
3. Create script _SliderController_.
4. Delete Start and Update methods.
5. Create public method OnSliderChanged that takes one float parameter.
6. Add field _valueText_ and inside a new method assign it with method parameter.
7. Inside _Slider_ component add new script to events list and change method name.
8. You can also make the slider prettier: change it Handle, Background and Fill area.

## Progress bar (with buttons)
1. Create a __Canvas__ (change a background color and add other elements you need).
2. Add a __Button__ and a __Slider__ to the Canvas (uncheck _Interactable_ in Slider component or just delete _Handle Slide Area_).
3. Create new script _Progressbar_.
4. Create a variable that will hold a progress.
5. Add slider reference.
6. Create _UpdateProgress_ public method.
7. Increase _progress_ value and set it as slider value;
8. In Button register a new event from slider (drug slider into new event).
9. In Progressbar script choose UpdateProgress() method.
10. You can also create a second __Button__ (Remove) and create a new method (__RemoveProgress__). After that register a new event from slider.

## Timer
1. Create a __Canvas__ (change a background color and add other elements you need).
2. Add __Slider__, change its color as you wish.
3. Delete _Handle Slide Area_.
4. Set slider to it max value.
5. In Slider add _TimerText_ to show time left.
6. Create an __empty GameObject__ (rename it to _TimerController_).
7. Create a new C#-script (_Timer_).
8. Add this script to TimerController.
9. In the script add reference to Slider.
10. Create public field for timer text.
11. Create variable _float maxTime_ (max game time).
12. Create private _bool stopTimer_ (we need to know when we stop the timer).
13. In Start set stopTimer to false.
14. In Start set timerSlider maxValue and value to maxTime;
15. In Update create a new variable _float time_ and set its value to maxTime - Time.time.
16. In Update calculate a number of minutes that left.
17. In Update calculate a number of seconds that left.
18. Create string variable for correct time format.
19. Set stopTimer to true if time <= 0.
20. If !stopTimer - update timer value and timerText.text.