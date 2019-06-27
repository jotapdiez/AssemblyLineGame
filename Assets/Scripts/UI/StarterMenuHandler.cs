using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StarterMenuHandler : MonoBehaviour
{
    public Texture2D tex;

    private Sprite resourceTexture;
    public GameObject onOffButton;
    public GameObject spawnCountText;

    public Dropdown resourceTypeSelector;

    public Element parent;

    void Start()
    {
        // tex = Resources.Load<Texture2D>("Textures/EmptyResource");
        OnOff();
        spawnChange();
        loadResourceTypeSelector();
        resourceTypeSelector.onValueChanged.AddListener(delegate
        {
            resourceTypeSelectorChange2(resourceTypeSelector);
        });
    }

    void Update()
    {

    }

    public void resourceTypeSelectorChange2(Dropdown change){
        Dropdown.OptionData opt = resourceTypeSelector.options[change.value];
        PrimitiveResourceType type = PrimitiveResourceTypeData.fromString(opt.text);
        resourceTypeSelector.captionImage.color = new PrimitiveResourceTypeData(type).getColor();
        parent.GetComponent<StarterController>().setResourceType(type);
    }

    private void loadResourceTypeSelector(){
        resourceTypeSelector.ClearOptions();
        foreach (PrimitiveResourceType res in Enum.GetValues(typeof(PrimitiveResourceType)))
        {
            PrimitiveResourceTypeData data = new PrimitiveResourceTypeData(res);
            Color color = data.getColor();

            var texture = new Texture2D(1,1);
            texture.SetPixel(0, 0, color); // setting to this pixel some color
            texture.Apply();

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0));
            Dropdown.OptionData item = new Dropdown.OptionData(res.ToString(), sprite);
            resourceTypeSelector.options.Add(item);
        }
    }

    public void OnOff(){
        Button btn = onOffButton.GetComponent<Button>();
        ColorBlock cb = btn.colors;
        string text = "Off";
        if (parent.isActive()){
            text = "On";
            cb.normalColor = Color.green;
            cb.pressedColor = Color.green;
            cb.highlightedColor = Color.green;
        }else{
            text = "Off";
            cb.normalColor = Color.red;
            cb.pressedColor = Color.red;
            cb.highlightedColor = Color.red;
        }
        btn.colors = cb;
        btn.GetComponentInChildren<Text>().text = text;
    }

    public void spawnChange(){
        string spawnCount = parent.GetComponent<StarterController>().SpawnCount.ToString();
        spawnCountText.GetComponent<InputField>().text = spawnCount;
    }

    public void resourceTypeChange(PrimitiveResourceType type){
        parent.GetComponent<StarterController>().setResourceType(type);
    }
}
