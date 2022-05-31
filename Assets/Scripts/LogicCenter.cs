using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using FuzzyLogic;
using FuzzyLogic.Memberships;

public class LogicCenter : MonoBehaviour
{

    public void Start()
    {
        Run();
    }
    public void Run()
    {
        RuleInferenceEngine rie = new RuleInferenceEngine();

        FuzzySet speed = new FuzzySet("speed", 0, 5, 0.1);

        speed.AddMembership("Slow", new FuzzyReverseGrade(0, 1.75));
        speed.AddMembership("Middle", new FuzzyTriangle(1, 2.5, 4));
        speed.AddMembership("Fast", new FuzzyGrade(3.25, 5));
        rie.AddFuzzySet(speed.Name, speed);

        FuzzySet ls = new FuzzySet("LeftSensor", 0, 7, 0.1);
        ls.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        ls.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        ls.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(ls.Name, ls);


        FuzzySet cs = new FuzzySet("CenterSensor", 0, 7, 0.1);
        cs.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        cs.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        cs.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(cs.Name, cs);

        FuzzySet rs = new FuzzySet("RightSensor", 0, 7, 0.1);
        rs.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        rs.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        rs.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(rs.Name, rs);

        //Здесь правила


        Rule rule = new Rule("Rule 1");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 2");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 3");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 4");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 5");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 6");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 7");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 8");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 9");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 10");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 11");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 12");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 13");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 14");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 15");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed,
        "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 16");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 17");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 18");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 19");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 20");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 21");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Slow");
        rie.AddRule(rule);

        rule = new Rule("Rule 22");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 23");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Middle");
        rie.AddRule(rule);

        rule = new Rule("Rule 24");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 25");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        rule = new Rule("Rule 26");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(speed, "Is", "Fast");
        rie.AddRule(rule);

        //
        ls.X = 5;
        ls.GetMembership("Close").degree(ls.X);
        ls.GetMembership("Middle").degree(ls.X);
        ls.GetMembership("Far").degree(ls.X);

        cs.X = 2.5;
        ls.GetMembership("Close").degree(ls.X);
        ls.GetMembership("Middle").degree(ls.X);
        ls.GetMembership("Far").degree(ls.X);

        rs.X = 0.5;
        rs.GetMembership("Close").degree(rs.X);
        rs.GetMembership("Middle").degree(rs.X);
        rs.GetMembership("Far").degree(rs.X);

        rie.Infer(speed);

        Debug.Log("Подсчитанная скорость = " + speed.X);
    }

}
