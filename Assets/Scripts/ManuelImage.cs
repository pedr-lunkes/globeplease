using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Image displayImage; // O componente de Image do prefab para exibir a imagem atual
    public Button leftButton; // Bot�o para ir para a imagem anterior
    public Button rightButton; // Bot�o para ir para a pr�xima imagem

	public Button leftButton2; // Bot�o para ir para a imagem anterior
	public Button rightButton2; // Bot�o para ir para a pr�xima imagem

	public Sprite[] imageArray; // Um array de imagens (defina 3 imagens aqui no inspector)

    private int currentIndex = 0; // �ndice da imagem atualmente exibida

    void Start()
    {
        // Exibe a primeira imagem ao iniciar
        displayImage.sprite = imageArray[currentIndex];

        // Configura os listeners para os bot�es
        leftButton.onClick.AddListener(ShowPreviousImage);
        rightButton.onClick.AddListener(ShowNextImage);

		leftButton2.onClick.AddListener(ShowPreviousImage);
		rightButton2.onClick.AddListener(ShowNextImage);

		// Verifica se o bot�o da esquerda precisa estar desabilitado inicialmente
		UpdateButtonState();
    }

    // Fun��o para mostrar a imagem anterior
    void ShowPreviousImage()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            displayImage.sprite = imageArray[currentIndex];
        }
        UpdateButtonState();
    }

    // Fun��o para mostrar a pr�xima imagem
    void ShowNextImage()
    {
        if (currentIndex < imageArray.Length - 1)
        {
            currentIndex++;
            displayImage.sprite = imageArray[currentIndex];
        }
        UpdateButtonState();
    }

    // Atualiza o estado dos bot�es dependendo da posi��o
    void UpdateButtonState()
    {
        // Se estamos na primeira imagem, o bot�o da esquerda deve estar desabilitado
        leftButton.interactable = currentIndex > 0;

        // Se estamos na �ltima imagem, o bot�o da direita deve estar desabilitado
        rightButton.interactable = currentIndex < imageArray.Length - 1;
    }
}
