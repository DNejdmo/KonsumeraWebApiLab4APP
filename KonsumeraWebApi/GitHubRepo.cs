using System;
using System.Text.Json.Serialization;


    internal class GitHubRepo
    {
        [property: JsonPropertyName("name")]
        public string Name { get; set; }

        [property: JsonPropertyName("description")]
        public string Description { get; set; }

        [property: JsonPropertyName("html_url")]
        public string Github { get; set; }

        [property: JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [property: JsonPropertyName("watchers")]
        public int Watchers { get; set; }

        [property: JsonPropertyName("pushed_at")]
        public DateTime PushedAt { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name} \nDescription: {this.Description} \nGitHub: {this.Github} \nHomepage: " +
                $"{this.Homepage} \nWatchers: {this.Watchers} \nPushed at: {this.PushedAt}";
        }
    }

