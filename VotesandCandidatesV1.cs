using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

public class Program
{
    private static void Main()
    {
        int[] VoteData = new int[5];
        int CandidateNum = 0;
        int BestVote = 0;

        GetCandidates(ref CandidateNum);
        GetVotes(ref VoteData, CandidateNum);
        ProcessVotes(ref BestVote, CandidateNum, VoteData);
        DisplayVotes(VoteData, BestVote, CandidateNum);

    }
    private static void GetCandidates(ref int CandidateNum)
    {
        Console.Write("Enter the amount of candidates there are: ");
        CandidateNum = int.Parse(Console.ReadLine());


    }
    private static void GetVotes(ref int[] VoteData, int CandidateNum)
    {
        for (int i = 0; i < CandidateNum; i++)
        {
            Console.Write($"Enter the amount of votes for candidate {i + 1}: ");
            VoteData[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void ProcessVotes(ref int BestVote, int CandidateNum, int[] VoteData)
    {

        for (int i = 0; i < CandidateNum; i++)
        {
            if (BestVote < VoteData[i])
            {
                BestVote = VoteData[i];
            }
        }
    }

    private static void DisplayVotes(int[] VoteData, int BestVote, int CandidateNum)
    {
        int WinnerNum = 0;
        for (int i = 0;i < CandidateNum; i++) 
        { 
            if (BestVote == VoteData[i]) {
                WinnerNum = i;
            }
        }
        Console.Write($"The winner is candidate {WinnerNum + 1} with {BestVote} votes");
    }
}
