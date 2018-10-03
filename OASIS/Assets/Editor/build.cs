using UnityEditor;

  class WebGLBuilder {
      static void build() {
          string[] scenes = {"Assets/Scenes/Main.unity"};
          BuildPipeline.BuildPlayer(scenes, "dist", BuildTarget.WebGL, BuildOptions.None);
      }
  }
