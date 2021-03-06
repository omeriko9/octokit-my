﻿namespace Octokit
{
    public class GitDatabaseClient : ApiClient, IGitDatabaseClient
    {
        public GitDatabaseClient(IApiConnection apiConnection) 
            : base(apiConnection)
        {
            Blob = new BlobsClient(apiConnection);
            Tree = new TreesClient(apiConnection);
            Tag = new TagsClient(apiConnection);
            Commit = new CommitsClient(apiConnection);
            Reference = new ReferencesClient(apiConnection);
        }

        public IBlobsClient Blob { get; set; }
        public ITreesClient Tree { get; set; }
        public ITagsClient Tag { get; set; }
        public ICommitsClient Commit { get; set; }
        public IReferencesClient Reference { get; set; }
    }
}