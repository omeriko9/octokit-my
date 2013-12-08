﻿namespace Octokit
{
    public class RepositoryIssueRequest : IssueRequest
    {
        /// <summary>
        /// Identifies a filter for the milestone. Use "*" for issues with any milestone.
        /// Use the milestone number for a specific milestone. Use the value "none" for issues with any milestones.
        /// </summary>
        public string Milestone { get; set; }
    }
}
