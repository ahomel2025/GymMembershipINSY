using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.model;

public class Gym
{
    private List<GymMembership> memberships = new List<GymMembership>();
    private List<Trainer> trainers = new List<Trainer>();
    //This allows a list of Trainers and GymMemberships for the database to recognize

    public void CreateMembership(string name, DateTime startDate, DateTime endDate, string membershipType)
    {
        GymMembership newMember = new GymMembership(name, startDate, endDate, membershipType);
        memberships.Add(newMember);
        Console.WriteLine($"{name}'s {membershipType} membership has been created");
    }
    // This method allows people to create membership for people

    public void RenewMembership(string name, int months)
    {
        GymMembership member = memberships.Find(m => m.MemberName == name);
        if (member != null)
        {
            member.RenewMembership(months);
        }
        else
        {
            Console.WriteLine("Member not found");
        }
    }
    //This method allows people to renew their membership if they are expired

    public void AddTrainer(string name, string specialization)
    {
        Trainer newTrainer = new Trainer(name, specialization);
        trainers.Add(newTrainer);
        Console.WriteLine($"Trainer {name} has been added with specialization in {specialization}");
    }
    //This allows the gym to add Trainers to the database

    public void DisplayTrainers()
    {
        foreach (var trainer in trainers)
        {
            trainer.DisplayDetails();
        }

    }
    //This method shows a list of the different trainers
}