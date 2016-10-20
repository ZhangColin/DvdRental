﻿using System.Collections.Generic;
using DVDRental.Subscription.Subscriptions;

namespace DVDRental.Subscription.Allocation
{
    public class AllocationService
    {
        public void Allocate(Subscriptions.Subscription subscription, CurrentPeriodRentals currentPeriodRentals,
            IEnumerable<Allocation> currentAllocations, Allocation allocation)
        {
            if (subscription.IsEligibleToRecieveAFilm(currentPeriodRentals, currentAllocations)) 
            {
                if (allocation!=null)
                {
                    allocation.AllocateUnitTo(subscription.Id);
                }
            }
        }
    }
}