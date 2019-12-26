using cleanArchitecture.Application.Common.Interfaces;
using System;

namespace cleanArchitecture.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
