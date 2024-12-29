using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class VasiAnimationLoader
{
    public List<AnimationFrame> LoadAnimation(string filePath)
    {
        List<AnimationFrame> frames = new List<AnimationFrame>();
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    AnimationFrame frame = new AnimationFrame
                    {
                        spriteName = parts[0],
                        duration = float.Parse(parts[1])
                    };
                    frames.Add(frame);
                }
            }
        }
        else
        {
            Debug.LogError("Animation file not found: " + filePath);
        }
        return frames;
    }

    private class AnimationFrame
    {
        public string spriteName;
        public float duration;
    }
}