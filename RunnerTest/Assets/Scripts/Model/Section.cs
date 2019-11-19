using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section 
{
    private bool firstCheck = true;
    private const int SECTIONCOUNT = 5;
    private Queue<GameObject> sections;
    private float distanse = 0;

    public Section()
    {
        sections = new Queue<GameObject>();
        SetSection(SectionEnum.Section);
        while (sections.Count < SECTIONCOUNT)
            SetRandomSection();
    }

    private void SetRandomSection()
    {
        sections.Enqueue(ViewController.LoadSection(
            EnumContoller.RandomEnumValue<SectionEnum>(), 
            ref distanse));
    }
    private void SetSection(SectionEnum section)
    {
        sections.Enqueue(ViewController.LoadSection(section, ref distanse));
    }

    public void UpdateSections()
    {
        if (firstCheck)
        {
            firstCheck = false;
            return;
        }
        ViewController.DestoyGameObject(sections.Dequeue());
        SetRandomSection();
    }
    public void RemoveAllSections()
    {
        while (sections.Count > 0)
            ViewController.DestoyGameObject(sections.Dequeue());
    }
}
