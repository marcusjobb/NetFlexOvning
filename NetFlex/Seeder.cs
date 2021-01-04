namespace NetFlex
{
    /// <summary>
    /// Defines the <see cref="Seeder" />.
    /// </summary>
    public static class Seeder
    {
        /// <summary>
        /// Create a json string to use as template.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public static string CreateMovies() =>
            "[ { \"Length\": 98, \"Name\": \"Lost Boys\", \"Genre\": \"Horror / Komedi\", \"Year\": 1987 }, { \"Length\": 101, \"Name\": \"Labyrinth\", \"Genre\": \"Musical\", \"Year\": 1986 } ]";

        /// <summary>
        /// Create a json string to use as template.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public static string CreateSeries() =>
            "[{\"Episodes\": 55,\"Seasons\": 3,\"Name\": \"Shadowhunters\",\"Genre\": \"Action, Drama, Fantasy\",\"Year\": 2016},{\"Episodes\": 27,\"Seasons\": 3,\"Name\": \"Penny Deadful\",\"Genre\": \" Drama, Fantasy, Horror\",\"Year\": 2014}]";
    }
}
