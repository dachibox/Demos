﻿using Newtonsoft.Json;

namespace ImageSearch.Services.BingSearch
{
    class Thumbnail
    {
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
