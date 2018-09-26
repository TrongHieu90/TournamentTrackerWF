namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}