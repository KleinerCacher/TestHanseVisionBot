using System;
using Microsoft.Bot.Builder.FormFlow;

public enum CustomerOptions {HPA = 1, DataPort, Bonprix, HanseVision}

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! Wie ist Dein Name?")]
    public string Name { get; set; }

    [Prompt("Für welchen Kunden ist Dein Projekt? {||}")]
    public CustomerOptions Customer  { get; set; }

    [Prompt("Wie ist der Titel Deines Projekts?")]
    public string Title { get; set; }

    [Prompt("Wer ist der Projektmanager?")]
    public string ProjectManager { get; set; }


    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
