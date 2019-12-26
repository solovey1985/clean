using cleanArchitecture.Application.Common.Interfaces;
using System;

namespace cleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
