using SemanticAnalyzer.Core.Common.Entities;
using SemanticAnalyzer.Core.Enums;

namespace SemanticAnalyzer.Core.Entities;

/// <summary>
/// Entity class that represents a category of analysis prompts.
/// </summary>
public class AnalysisPromptCategory : IEntity
{
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the type of analysis prompt category.
    /// </summary>
    public string Category { get; set; } = default!;

    /// <summary>
    /// Gets or sets the type of prompt.
    /// </summary>
    public PromptType PromptType { get; set; } 

    /// <summary>
    /// Gets or sets the ID of the selected prompt.
    /// </summary>
    public Guid? SelectedPromptId { get; set; }

    /// <summary>
    /// Gets or sets the selected prompt.
    /// </summary>
    public AnalysisPrompt? SelectedPrompt { get; set; }

    /// <summary>
    /// Gets or sets the collection of prompts.
    /// </summary>
    public ICollection<AnalysisPrompt> Prompts { get; set; } = new List<AnalysisPrompt>();

    /// <summary>
    /// Gets or sets the collection of workflow execution options associated with this category.
    /// </summary>
    public ICollection<WorkflowExecutionOption> WorkflowExecutionOptions { get; set; } = default!;
}