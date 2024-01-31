using System;

namespace AfghanCalendar.PopupControl
{
    [Flags]
    internal enum PopupAnimations
    {
        None = 0,
        LeftToRight = 1,
        RightToLeft = 2,
        TopToBottom = 4,
        BottomToTop = 8,
        Center = 16,
        Slide = 262144,
        Blend = 524288,
        Roll = 1048576,
        SystemDefault = 2097152,
    }
}
