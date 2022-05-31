using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


using FuzzyLogic;
using FuzzyLogic.Memberships;

public class LogicCenter : MonoBehaviour
{
    public GameObject Car;

    public GameObject SensorInfo;

    FuzzySet speed, rotation;

    FuzzySet ls, cs, rs;

    RuleInferenceEngine rie;

    public void Start()
    {
        CreateSystem();
        AddRulesSpeed();
    }

    public void Update()
    {
        GetSensors();
        Run();
        AddRulesRotation();
    }

    public void AddRulesSpeed()
    {
        //����� �������
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
        rule.Consequent = new Clause(speed, "Is", "Middle");
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
    }

    public void AddRulesRotation()
    {
        //����� �������
        Rule rule = new Rule("Rule 101");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 102");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 103");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 104");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 105");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 106");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 107");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 108");
        rule.AddAntecedent(new Clause(ls, "Is", "Close"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 109");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 110");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 111");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 112");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 113");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 114");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 115");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 116");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 117");
        rule.AddAntecedent(new Clause(ls, "Is", "Middle"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 118");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 119");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 120");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Close"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 121");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 122");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 123");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Middle"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Right");
        rie.AddRule(rule);

        rule = new Rule("Rule 124");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Close"));
        rule.Consequent = new Clause(rotation, "Is", "Left");
        rie.AddRule(rule);

        rule = new Rule("Rule 125");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Middle"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);

        rule = new Rule("Rule 126");
        rule.AddAntecedent(new Clause(ls, "Is", "Far"));
        rule.AddAntecedent(new Clause(cs, "Is", "Far"));
        rule.AddAntecedent(new Clause(rs, "Is", "Far"));
        rule.Consequent = new Clause(rotation, "Is", "Forward");
        rie.AddRule(rule);
    }

    public void CreateSystem()
    {
        rie = new RuleInferenceEngine();

        speed = new FuzzySet("speed", 0, 5, 0.1);

        rotation = new FuzzySet("rotation", -10, 10, 0.1);

        speed.AddMembership("Slow", new FuzzyReverseGrade(0, 1.75));
        speed.AddMembership("Middle", new FuzzyTriangle(1, 2.5, 4));
        speed.AddMembership("Fast", new FuzzyGrade(3.25, 5));
        rie.AddFuzzySet(speed.Name, speed);

        rotation.AddMembership("Left", new FuzzyReverseGrade(-10, 0));
        rotation.AddMembership("Forward", new FuzzyTriangle(-5, 0, 5));
        rotation.AddMembership("Right", new FuzzyGrade(0, 10));
        rie.AddFuzzySet(rotation.Name, rotation);

        ls = new FuzzySet("LeftSensor", 0, 7, 0.1);
        ls.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        ls.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        ls.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(ls.Name, ls);


        cs = new FuzzySet("CenterSensor", 0, 7, 0.1);
        cs.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        cs.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        cs.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(cs.Name, cs);

        rs = new FuzzySet("RightSensor", 0, 7, 0.1);
        rs.AddMembership("Close", new FuzzyReverseGrade(0, 2));
        rs.AddMembership("Middle", new FuzzyTriangle(1, 3, 5));
        rs.AddMembership("Far", new FuzzyGrade(4, 6));
        rie.AddFuzzySet(rs.Name, rs);
    }

    public void Run()
    {
       
        //
        ls.GetMembership("Close").degree(ls.X);
        ls.GetMembership("Middle").degree(ls.X);
        ls.GetMembership("Far").degree(ls.X);

        ls.GetMembership("Close").degree(ls.X);
        ls.GetMembership("Middle").degree(ls.X);
        ls.GetMembership("Far").degree(ls.X);

        rs.GetMembership("Close").degree(rs.X);
        rs.GetMembership("Middle").degree(rs.X);
        rs.GetMembership("Far").degree(rs.X);

        rie.Infer(speed);

        rie.Infer(rotation);

        Debug.Log("������������ �������� = " + speed.X);
        Debug.Log("������������ �������  = " + rotation.X);

        if(!Double.IsNaN(speed.X))
            SetSpeed((float)speed.X);

        if(!Double.IsNaN(rotation.X))
            SetRotation((float)rotation.X);
    }

    void GetSensors()
    {
        if (SensorInfo.GetComponent<SensorController>().masDist is object)
        {
            ls.X = SensorInfo.GetComponent<SensorController>().masDist[0];
            cs.X = SensorInfo.GetComponent<SensorController>().masDist[1];
            rs.X = SensorInfo.GetComponent<SensorController>().masDist[2];
        }
    }

    void SetSpeed(float spd)
    {
        //�������� �� ������
        Car.GetComponent<MoveMechanics>().speed = spd;
    }

    void SetRotation(float rt)
    {
        //�������� �� ������
        Car.GetComponent<MoveMechanics>().Angle += rt;
    }

}
