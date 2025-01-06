using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup mainMenuPanel;
    [SerializeField] private CanvasGroup tutorialPanel;

    private void Awake()
    {
        EnableOrDisableCanvasGroup(mainMenuPanel, true);
        EnableOrDisableCanvasGroup(tutorialPanel, false);
    }

    private static void EnableOrDisableCanvasGroup(CanvasGroup group, bool condition)
    {
        group.alpha = condition ? 1 : 0;
        group.interactable = condition;
        group.blocksRaycasts = condition;
    }

    public void EnableMainMenuPanel()
    {
        EnableOrDisableCanvasGroup(mainMenuPanel, true);
        EnableOrDisableCanvasGroup(tutorialPanel, false);
    }

    public void EnableTutorialPanel()
    {
        EnableOrDisableCanvasGroup(mainMenuPanel, false);
        EnableOrDisableCanvasGroup(tutorialPanel, true);
    }
    
    // TODO: Do the YES/NO tutorial UI
}
