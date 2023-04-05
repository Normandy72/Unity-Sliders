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

## Circular Slider
1. Create __Canvas__, change its background, set UI Scale Mode to Scale with screen size.
2. Create __Slider__, delete _Handle Slide Area_, set Transition to None, uncheck Interactable.
3. Rename slider background to OuterBorder.
4. Create a new __Sprite__ (Circle).
5. Add circle to OuterBorder source image.
6. Set Slider Width and Height to 160.
7. Stretch OuterBorder, set buttom and top to 0.
8. Stretch Fill Area, set left, top, right and bottom to 5.
9. Add circle to Fill source image.
10. Stretch Fill, set left, top, right and bottom to 0.
11. Change Fill color, set image type to Filled.
12. Dublicate OuterBorder, rename it to InnerBorder, set left, top, right, bottom to 20.
13. Dublicate InnerBorder, rename to CenterArea and put into InnerBorder.
14. In CenterArea set left, top, right, bottom to 5, change its color to main background color.

## Mission Slider
1. Create a __Canvas__, change background color.
2. Add a __Panel__ (rename to _ContainerPanel_), set Opacity to 0.
3. Inside ContainerPanel create a new __Panel__ (rename to _MissionsPanel_), resize it, change color or add sprite.
4. Inside MissonsPanel create __Button__ (rename it to _MissionButton1_), add Text (number 1).
5. Duplicate this button 8 times.
6. Duplicate MissionPanel, drop it to right.
7. Add 2 __Button__ for slider (Slide to right and to left).
8. Create a new script _MissionSlider_, attach it to Canvas (or othr parent object).
9. In script create field (reference to ContainerPanel).
10. Create reference to all MissionsPanel.
11. Create reference to right and left buttons.
12. Create field _int currentIndex_.
13. Create field _float containerPositionX_, initialize in Start method.
14. Set up a iTween asset from assets store.
15. Call MoveTo method through the code.
16. In Unity attach events to buttons.