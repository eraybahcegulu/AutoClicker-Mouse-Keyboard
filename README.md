# AutoClicker

require Administrator
```
<requestedExecutionLevel level="requireAdministrator" uiAccess="false" />
```

* ?fix, Countdown only updating when clicked or pressed

![1](https://github.com/eraybahcegulu/AutoClicker-Mouse-Keyboard/assets/84785201/b6aafe5a-72bf-4501-8715-7753136c0481)

![2](https://github.com/eraybahcegulu/AutoClicker-Mouse-Keyboard/assets/84785201/c870eddf-41f1-46c7-aafe-78c211f7973f)

![3](https://github.com/eraybahcegulu/AutoClicker-Mouse-Keyboard/assets/84785201/2812e2ea-2469-4b89-b97a-c57fae929691)

```
SW_HIDE (0): Pencereyi gizle.
SW_SHOWNORMAL (1): Pencereyi normal boyutta göster.
SW_SHOWMINIMIZED (2): Pencereyi küçültülmüş durumda göster.
SW_SHOWMAXIMIZED (3): Pencereyi tam ekran (büyütülmüş) olarak göster.
SW_SHOWNOACTIVATE (4): Pencereyi normal durumda göster, ancak etkinleştirme yapma.
SW_SHOW (5): Pencereyi en sonki boyutta ve konumda göster.
SW_MINIMIZE (6): Pencereyi minimize (küçültülmüş) duruma getir.
SW_SHOWMINNOACTIVE (7): Pencereyi minimize durumda göster, ancak etkinleştirme yapma.
SW_SHOWNA (8): Pencereyi en sonki durumda göster, ancak etkinleştirme yapma.
SW_RESTORE (9): Pencereyi geri yüklenmiş (restore) durumda göster.
SW_SHOWDEFAULT (10): Windows'un pencere durumunu varsayılan olarak belirler.

WH_KEYBOARD (2): Klavye olaylarını takip etmek için kullanılır. Ancak, daha modern uygulamalarda genellikle WH_KEYBOARD_LL (Low-Level Keyboard Hook) tercih edilir.
WH_MOUSE (7): Fare olaylarını takip etmek için kullanılır. Bu hook türü, fare tıklamaları ve hareketleri gibi olayları izler.



VK_SPACE	0x20	SPACEBAR

wVk = (ushort)keyCode,
wScan = 0,
dwFlags = 0,
time = 0,
dwExtraInfo = IntPtr.Zero

ki
wVk: Virtual key code
wScan: 0
dwFlags:  25 > KEYEVENTF_KEYDOWN
time
dwExtraInfo: 0

hi
uMsg:
wParamL:
wParamH:

        LEFTDOWN = 0x0002,
        LEFTUP = 0x0004,
        RIGHTDOWN = 0x0008,
        RIGHTUP = 0x0010,
        MIDDLEDOWN = 0x0020,
        MIDDLEUP = 0x0040,


        ///</summary>
        SPACE = 0x20,
        ///<summary>

        ///</summary>
        KEY_W = 0x57,
        ///<summary>
        ///</summary>
        KEY_A = 0x41,
        ///<summary>
        ///</summary>
        KEY_S = 0x53,
        ///<summary>
        ///</summary>
        KEY_D = 0x44,
        ///<summary>

        ///<summary>
        ///F1 key
        ///</summary>
        F1 = 0x70,
        ///<summary>
        ///F2 key
        ///</summary>
        F2 = 0x71,
        ///<summary>
        ///F3 key
        ///</summary>
        F3 = 0x72,
        ///<summary>
        ///F4 key
        ///</summary>
        F4 = 0x73,
        ///<summary>
        ///F5 key
        ///</summary>
        F5 = 0x74,
        ///<summary>
        ///F6 key
        ///</summary>
        F6 = 0x75,
        ///<summary>
        ///F7 key
        ///</summary>
        F7 = 0x76,
        ///<summary>
        ///F8 key
        ///</summary>
        F8 = 0x77,
        ///<summary>
        ///F9 key
        ///</summary>
        F9 = 0x78,
        ///<summary>
        ///F10 key
        ///</summary>
        F10 = 0x79,
        ///<summary>
        ///F11 key
        ///</summary>
        F11 = 0x7A,
        ///<summary>
        ///F12 key
        ///</summary>
        F12 = 0x7B,
        ///<summary>

```
