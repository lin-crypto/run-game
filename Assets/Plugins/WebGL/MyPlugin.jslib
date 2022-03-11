mergeInto(LibraryManager.library, {
  onGameOver: function (score) {
    ReactUnityWebGL.onGameOver(score);
  },
});