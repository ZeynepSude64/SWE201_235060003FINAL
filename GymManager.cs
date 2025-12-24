using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementApp.Models;

namespace GymManagementApp.Services
{
    public class GymManager
    {
        public void Start()
        {
            Member member = new Member(1, "Zeynep Sude Sümer", 20);
            Trainer trainer = new Trainer("Ahmet Yılmaz", "Fitness");
            Membership membership = new Membership("Aylık", 1200);

            member.ShowInfo();
            trainer.ShowTrainer();
            membership.ShowMembership();
        }
    }
}
