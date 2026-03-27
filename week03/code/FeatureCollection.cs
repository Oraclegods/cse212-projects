public class FeatureCollection
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
{
    // The top level of the JSON has a list called "features"
    public Feature[] Features { get; set; }
}

public class Feature
{
    // Each feature has a sub-dictionary called "properties"
    public Properties Properties { get; set; }
}

public class Properties
{
    // Inside properties, we find the data we actually want
    public string Place { get; set; }
    public decimal? Mag { get; set; } // Use decimal? because some mags might be null
}