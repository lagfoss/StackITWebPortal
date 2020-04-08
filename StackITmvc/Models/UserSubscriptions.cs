using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackITmvc.Models
{
    public class UserSubscriptions
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}
