using UnityEngine;
using UnityEngine.UIElements;
public class MainMenu : MonoBehaviour
{
    private UIDocument _document;
    private Button _playButton;
    private VisualElement _mainMenuScreen;
    private VisualElement _yesnoScreen;
    private Button _noButton;
    private Button _yesButton;
    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _playButton = _document.rootVisualElement.Q<Button>("Play");
        _noButton = _document.rootVisualElement.Q<Button>("no");
        _yesButton = _document.rootVisualElement.Q<Button>("yes");
        _mainMenuScreen = _document.rootVisualElement.Q<VisualElement>("mainMenu");
        _yesnoScreen = _document.rootVisualElement.Q<VisualElement>("tutorialmenu");
        _playButton.RegisterCallback<ClickEvent>(OnPlayGameClick);
        _noButton.RegisterCallback<ClickEvent>(StartGame);
        _yesButton.RegisterCallback<ClickEvent>(StartTutorial);

        _mainMenuScreen.style.display = DisplayStyle.Flex;
        _yesnoScreen.style.display = DisplayStyle.None;
    }

    private void OnDisable()
    {
        _playButton.UnregisterCallback<ClickEvent>(OnPlayGameClick);
    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        _mainMenuScreen.style.display = DisplayStyle.None;
        _yesnoScreen.style.display = DisplayStyle.Flex;
    }

    private void StartTutorial(ClickEvent clickEvent)
    {
        GameManager.instance.isTutorialLevel = true;
        _yesnoScreen.style.display = DisplayStyle.None;
    }

    private void StartGame(ClickEvent clickEvent)
    {
        GameManager.instance.isTutorialLevel = false;
        _yesnoScreen.style.display = DisplayStyle.None;
    }
}
