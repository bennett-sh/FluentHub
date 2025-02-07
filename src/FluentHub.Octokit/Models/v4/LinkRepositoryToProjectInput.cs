namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of LinkRepositoryToProject
    /// </summary>
    public class LinkRepositoryToProjectInput
    {
        /// <summary>
        /// The ID of the Project to link to a Repository
        /// </summary>
        public ID ProjectId { get; set; }

        /// <summary>
        /// The ID of the Repository to link to a Project.
        /// </summary>
        public ID RepositoryId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}