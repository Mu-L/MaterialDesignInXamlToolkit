﻿using MaterialDesignThemes.Wpf;

namespace MaterialDesignDemo.Domain;

internal class SmartHintViewModel : ViewModelBase
{
    private bool _floatHint = true;
    private FloatingHintHorizontalAlignment _selectedAlignment = FloatingHintHorizontalAlignment.Inherit;
    private double _selectedFloatingScale = 0.75;
    private bool _showClearButton = true;
    private bool _showLeadingIcon = true;
    private string _hintText = "Hint text";
    private Point _selectedFloatingOffset = new (0, -16);

    public IEnumerable<FloatingHintHorizontalAlignment> HorizontalAlignmentOptions { get; } = Enum.GetValues(typeof(FloatingHintHorizontalAlignment)).OfType<FloatingHintHorizontalAlignment>();
    public IEnumerable<double> FloatingScaleOptions { get; } = new[] {0.25, 0.5, 0.75, 1.0};

    public IEnumerable<Point> FloatingOffsetOptions { get; } = new[] { new Point(0, -16), new Point(0, 16), new Point(16, 16), new Point(-16, -16) };

    public IEnumerable<string> ComboBoxOptions { get; } = new[] {"Option 1", "Option 2", "Option 3"};

    public bool FloatHint
    {
        get => _floatHint;
        set
        {
            _floatHint = value;
            OnPropertyChanged();
        }
    }

    public FloatingHintHorizontalAlignment SelectedAlignment
    {
        get => _selectedAlignment;
        set
        {
            _selectedAlignment = value;
            OnPropertyChanged();
        }
    }

    public double SelectedFloatingScale
    {
        get => _selectedFloatingScale;
        set
        {
            _selectedFloatingScale = value;
            OnPropertyChanged();
        }
    }

    public Point SelectedFloatingOffset
    {
        get => _selectedFloatingOffset;
        set
        {
            _selectedFloatingOffset = value;
            OnPropertyChanged();
        }
    }

    public bool ShowClearButton
    {
        get => _showClearButton;
        set
        {
            _showClearButton = value;
            OnPropertyChanged();
        }
    }

    public bool ShowLeadingIcon
    {
        get => _showLeadingIcon;
        set
        {
            _showLeadingIcon = value;
            OnPropertyChanged();
        }
    }

    public string HintText
    {
        get => _hintText;
        set
        {
            _hintText = value;
            OnPropertyChanged();
        }
    }
}
