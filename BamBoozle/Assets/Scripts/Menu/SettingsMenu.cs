using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer Mixer;

    Resolution[] resoulitonsAva;

    public Dropdown resDropdown;

    void Start()
    {
        resoulitonsAva = Screen.resolutions;
        
        //Clear out options in dropdown...
        resDropdown.ClearOptions();  

        //list of strings that are our options...
        List<string> options = new List<string>();

        int currentRes = 0;
        //For every element in the res array, we get the resolution as a string...
        for (int i = 0; i < resoulitonsAva.Length; i++)
        {
            string option = resoulitonsAva[i].width + "x" + resoulitonsAva[i].height;
            //We add the resolution option to the options list...
            options.Add(option);

            //Here if the current res is equal to the ScreenRes, current res = i...
            if (resoulitonsAva[i].width == Screen.currentResolution.width &&
                resoulitonsAva[i].height == Screen.currentResolution.height)
            {
                currentRes = i;
            }
        }
        //Then the list is added to the resoultion Dropdown...
        resDropdown.AddOptions(options);
        //Here we are setting the Value to the ScreenRes, and refreshing the dropdown...
        resDropdown.value = currentRes;
        resDropdown.RefreshShownValue();
    }

    public void ResolutionSet(int resolutionIndex)
    {
        Resolution resolution = resoulitonsAva[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void VolumeSet(float volume)
    {
        Mixer.SetFloat("MasterVolume", volume);
    }

    public void QualitySet(int qualitylevel)
    {
        QualitySettings.SetQualityLevel(qualitylevel);
    }

    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
