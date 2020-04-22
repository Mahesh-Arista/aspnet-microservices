﻿using Web.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.Services
{
    public class RecommendationSvc : IRecommendationSvc
    {
        private readonly ILogger<TaxSvc> logger;
        private readonly HttpClient httpClient;
        private readonly IConfiguration cfg;

        public RecommendationSvc(HttpClient httpClient, IConfiguration cfg,  ILogger<TaxSvc> logger)
        {
            this.logger = logger;
            this.httpClient = httpClient;
            this.cfg = cfg;
        }

        public void GetRecommendedProducts(string productId)
        {
            // todo
            
        }
    }
}
