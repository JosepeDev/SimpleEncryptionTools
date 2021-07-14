public enum ChoosingState
{
    /// Represents a state in the menu.
    /// Choosing comparisons means the user is now choosing the types he wants to compare
    /// Choosing duration means the user is now choosing a benchmark preset group (Examples: "Fast", "Normal", "Long")
    /// Choosing preset is the last section, it means that the player is now a preset from the preset group he chose before.

    ChoosingComparisons = 0,
    ChoosingDuration = 1,
    ChoosingPreset = 2,
    Complete = 3,
}
