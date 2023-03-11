using System;
using System.Collections.Generic;
using Google.OrTools.LinearSolver;

public class CuttingStockSolver
{
    public static List<int> Solve(int stockLength, int[] widths, int[] demands)
    {
        // Initialize solver
        Solver solver = new Solver("CuttingStockSolver", Solver.OptimizationProblemType.CLP_LINEAR_PROGRAMMING);
        
        //Write to console
        Console.WriteLine("Stock length: " + stockLength);
        Console.WriteLine("Widths: " + string.Join(", ", widths));
        Console.WriteLine("Demands: " + string.Join(", ", demands));

        // Define variables
        List<Variable> x = new List<Variable>();
        foreach (int width in widths)
        {
            x.Add(solver.MakeIntVar(0, int.MaxValue, "x" + width));
        }
        
        // Define objective
        Objective obj = solver.Objective();
        obj.SetMinimization();
        obj.SetCoefficient(x[0], 1);
        
        // Define constraints
        foreach (int demand in demands)
        {
            Constraint constraint = solver.MakeConstraint(demand, int.MaxValue);
            for (int i = 0; i < x.Count; i++)
            {
                constraint.SetCoefficient(x[i], widths[i]);
            }
        }
        
        // Solve problem
        solver.Solve();
        
        // Get solution
        List<int> solution = new List<int>();
        foreach (Variable var in x)
        {
            int count = Convert.ToInt32(Math.Round(var.SolutionValue()));
            for (int i = 0; i < count; i++)
            {
                solution.Add(var.Name().Contains("x") ? Convert.ToInt32(var.Name().Substring(1)) : 0);
            }
        }
        return solution;
    }
}
