#Uif#
A **light-weight** pack of codes helps you to get your native Unity UI **moving** and **changing**.

The **Scenes/Main.unity** has all the moving and changing **in action**! Be sure to check it out!

##How to use##
You can use **base class** and setup reference to **any derived class** using native **Unity Inspector**!

No more messing with **GetComponent\<T\>** to find MonoBehaviour implementing a specific interface!

Copy Scripts/Libraries/Uif to your project and...
  - using **Uif**;
  - public **Hidable** myHidable;
  - myHidable.**Hide()**;
  - myHidable.**Show()**;

##Codes Overview##
Interfaces :
  - **IColorable** - Interface for setting and getting color
  - **IHidable** - Interface for hiding and showing
  - **ISwapable\<T\>** - Interface for changing generic type T

Abstract Classes :
  - **Colorable** - Base class implementing IColorable and derived from MonoBehaviour
  - **Hidable** - Base class implementing IHidable and derived from MonoBehaviour
  - **Swapable\<T\>** - Base class implementing ISwapable\<T\> and derived from MonoBehaviour
  - **ColorSwapable** - Base class derived from Swapable\<Color\> for changing color
  - **SpriteSwapable** - Base class derived from Swapable\<Sprite\> for changing sprite

Concrete Classes :
  - **GraphicColorable** - Class provide access to UI's color
  - **GraphicGroupColorable** - Class provide access to a group of UIs' color
  - **GraphicListColorable** - Class provide access to a list of UIs' color
  - **ColorableHidable** - Class allow you to hide or show Colorable by color
  - **RectClipHidable** - Class allow you to hide or show RectTransform by size
  - **RectPanelSlideHidable** - Class allow you to hide or show RectTransform by sizeDelta
  - **RectSlideHidable** - Class allow you to hide or show RectTransform by anchoredPosition
  - **ColorableSwapable** - Class let you change Colorable's color
  - **ImageSlideSwapable** - Class let you change Image's sprite by sliding
  - **ImageSwapable** - Class let you change Image's sprite by fading

##Version Informations##
Developing Environment :
  - Unity **5.3.4**

Minimum Environment :
  - Unity **4.6**
