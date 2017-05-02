using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

 /* public class AudioManager : MonoBehaviour {

    //Each song is located in the resources folder. Each song is loaded one at a time to keep things clean. 
    //To add songs just copy a song into the folder.
    //When song plays the UI will display the song name and artist for 3 seconds on bottom right.

    //public AudioClip[] clips;
    public AudioSource audioSource;
    public Text songName;
    public List<AudioClip> clips = new List<AudioClip>();
    public TextReader MusicListText;
    private string display = " ";
    public enum SeekDirection { Forward, Backward };

    private int currentIndex = 0;

    private FileInfo[] soundFiles;
    private List<string> validExtensions = new List<string> { " .ogg", ".wav" };

    private string absolutePath = "./7Audio/UserAudio";


    private string[] getSongList()
    {
        AudioClip[] allSongs = Resources.LoadAll<AudioClip>("songs");
        string[] allSongNames = new string[allSongs.Length];

        for (int index = 0; index < allSongs.Length; index++)
        {
            allSongNames[index] = allSongs[index].name;
        }
        return allSongNames;
    }

    //private AudioClip getRandomClip()
    //{
    //    return Resources.Load<AudioClip>("songs/" + allSongNames[Random.Range(0, allSongNames.Length)]);
    //}


    void Start()
    {
        if (Application.isEditor)
        {
            absolutePath = "Assets/7Audio/UserAudio";
        }
        if (audioSource == null)
        {
            audioSource = gameObject.AddcComponent<AudioSource>();
        }

        ReloadSounds();
    }


    //UI music controls - on pause menu
    public void playPrevious()
    {
        Seek(SeekDirection.Backward);
        PlayCurrent();
    }

    public void playNext()
    {
        Seek(SeekDirection.Forward);
        PlayCurrent();
    }

    public void ReloadAudio()
    {
        ReloadSounds();
    }

    void Seek(SeekDirection d)
    {
        if (d == SeekDirection.Forward)
        {
            currentIndex = (currentIndex + 1) % clips.Count;
        }
        else
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = clips.Count - 1;
            }
        }
    }

    public void PlayCurrent()
    {
        audioSource.clip = clips[currentIndex];
        audioSource.Play();
    }

    public void ReloadSounds()
    {
        //Finds all valid files
        clips.Clear();
        var info = new DirectoryInfo(absolutePath);
        soundFiles = info.GetFiles()
            .Where(f => IsValidFileType(f.Name))
                .ToArray();

        //Loads all valid files that it finds
        foreach (var s in soundFiles)
        {
            StartCoroutine(LoadFile(s.FullName));
        }

    }

    public bool isValidFileType(string fileName)
    {
        return validExtensions.Contains(Path.GetExtension(fileName));
    }

    IEnumerator LoadFile(string path)
    {
        WWW www = new WWW("file://" + path);
        print("loading from " + path);

        AudioClip clip = www.GetAudioClip(false);
        while (!clip.isReadyToPlay)
            yield return www;

        print("finshed loading");
        clip.name = Path.GetFileName(path);
        clips.Add(clip);

        int List = clips.Count;
        Debug.Log(List);
    }
} */
