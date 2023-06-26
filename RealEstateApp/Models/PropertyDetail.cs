﻿using Newtonsoft.Json;

namespace RealEstateApp.Models;

public class PropertyDetail
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("detail")]
    public string Detail { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("price")]
    public int Price { get; set; }

    [JsonProperty("imageUrl")]
    public string ImageUrl { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("bookmark")]
    public Bookmark Bookmark { get; set; }
}
