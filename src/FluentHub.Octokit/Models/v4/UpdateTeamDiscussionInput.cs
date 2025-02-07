namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateTeamDiscussion
    /// </summary>
    public class UpdateTeamDiscussionInput
    {
        /// <summary>
        /// The Node ID of the discussion to modify.
        /// </summary>
        public ID Id { get; set; }

        /// <summary>
        /// The updated title of the discussion.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The updated text of the discussion.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
        /// </summary>
        public string BodyVersion { get; set; }

        /// <summary>
        /// If provided, sets the pinned state of the updated discussion.
        /// </summary>
        public bool? Pinned { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}