using System;
using System.Runtime.InteropServices;
using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

[StructLayout(LayoutKind.Explicit, Size = 0x2A8)]
public unsafe struct AddonSelectOk
{
    [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
    [FieldOffset(0x220)] public AtkTextNode* PromptText;
    [FieldOffset(0x228)] public AtkComponentButton* OkButton;
}
/// <summary>
/// Addon SelectOk.
/// </summary>
public sealed unsafe class ClickSelectOk : ClickBase<ClickSelectOk, AddonSelectOk>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickSelectOk"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickSelectOk(IntPtr addon = default)
        : base("SelectOk", addon)
    {
    }

    public static implicit operator ClickSelectOk(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickSelectOk Using(IntPtr addon) => new(addon);


    /// <summary>
    /// Click the ok button.
    /// </summary>
    [ClickName("select_ok")]
    public void Ok()
        => this.ClickAddonButton(this.Addon->OkButton, 0);
}
