using System;
using UnityEngine;

namespace cn.sharerec {
#if UNITY_ANDROID

	public class JavaInterface {
		private AndroidJavaObject javaRecorder;

		public JavaInterface(string appkey, string appSecret) {
			try {
				AndroidJavaClass clz = null;
				clz = new AndroidJavaClass("cn.sharerec.recorder.impl.UnityRecorder");
				javaRecorder = clz.CallStatic<AndroidJavaObject>("getInstance", appkey, appSecret);
			} catch(Exception e) {
				javaRecorder = null;
			}
		}

		public void setGameObject(string gameObject) {
			if (javaRecorder != null) {
				javaRecorder.Call("setGameObject", gameObject);
			}
		}

		public void setOnRecorderStateListener(string callback) {
			if (javaRecorder != null) {
				javaRecorder.Call("setOnRecorderStateListener", callback);
			}
		}

		public void setSampleRate(int sampleRate) {
			if (javaRecorder != null) {
				javaRecorder.Call("setSampleRate", sampleRate);
			}
		}

		public void setChannelCount(int channelCount) {
			if (javaRecorder != null) {
				javaRecorder.Call("setChannelCount", channelCount);
			}
		}

		public void setFrameRate(int frameRate) {
			if (javaRecorder != null) {
				javaRecorder.Call("setFrameRate", frameRate);
			}
		}

		public void setRecordAudioFromMic(bool yes) {
			if (javaRecorder != null) {
				javaRecorder.Call("setRecordAudioFromMic", yes);
			}
		}

		public void onTheBeginningOfTheFrame() {
			if (javaRecorder != null) {
				javaRecorder.Call("onTheBeginningOfTheFrame");
			}
		}

		public void onTheEndOfTheFrame() {
			if (javaRecorder != null) {
				javaRecorder.Call("onTheEndOfTheFrame");
			}
		}

		public void start() {
			if (javaRecorder != null) {
				javaRecorder.Call("start");
			}
		}

		public void pause() {
			if (javaRecorder != null) {
				javaRecorder.Call("pause");
			}
		}

		public void resume() {
			if (javaRecorder != null) {
				javaRecorder.Call("resume");
			}
		}

		public void stop() {
			if (javaRecorder != null) {
				javaRecorder.Call("stop");
			}
		}

		public void setText(string text) {
			if (javaRecorder != null) {
				javaRecorder.Call("setText", text);
			}
		}

		public void addAttrData(string key, string value) {
			if (javaRecorder != null) {
				javaRecorder.Call("addAttrData", key, value);
			}
		}

		public bool isAvailable() {
			if (javaRecorder != null) {
				return javaRecorder.Call<bool>("isAvailable");
			}
			return false;
		}

		public void showShare(string callback) {
			if (javaRecorder != null) {
				javaRecorder.Call("showShare", callback);
			}
		}

		public void showVideoCenter(string callback) {
			if (javaRecorder != null) {
				javaRecorder.Call("showVideoCenter", callback);
			}
		}

		public void showProfile(string callback) {
			if (javaRecorder != null) {
				javaRecorder.Call("showProfile", callback);
			}
		}

		public void clearCache() {
			if (javaRecorder != null) {
				javaRecorder.Call("clearCache");
			}
		}

		public void setBitRate(int bitRate) {
			if (javaRecorder != null) {
				javaRecorder.Call("setBitRate", bitRate);
			}
		}

		public void onPreRender(int isPlugin) {
			if (javaRecorder != null) {
				javaRecorder.Call("onPreRender",isPlugin);
			}
		}
		
		public void onPostRender(int screenfbo) {
			if (javaRecorder != null) {
				javaRecorder.Call("onPostRender",screenfbo);
			}
		}

		public void OnRenderImage(int texture) {
			if (javaRecorder != null) {
				javaRecorder.Call("OnRenderImage",texture);
			}
		}

		public void setMaxFrameSize(int level, string callback) {
			if (javaRecorder != null) {
				javaRecorder.Call("setMaxFrameSize", level, callback);
			}
		}

		public long[] listLocalVideos() {
			if (javaRecorder != null) {
				return javaRecorder.Call<long[]>("listLocalVideos");
			}
			return new long[0];
		}

		public string getLocalVideoPath(long videoId) {
			if (javaRecorder != null) {
				return javaRecorder.Call<string>("getLocalVideoPath", videoId);
			}
			return null;
		}

		public void deleteLocalVideo(long videoId) {
			if (javaRecorder != null) {
				javaRecorder.Call<string>("deleteLocalVideo", videoId);
			}
		}
		
		public void setUseES3( bool bES3 ){
			if (javaRecorder != null) {
				javaRecorder.Call("setUseES3",bES3);
			}
		}

		public RECBar getRECBar(string gameObjet, string callback) {
			if (javaRecorder != null) {
				return new RECBar(javaRecorder, gameObjet, callback);
			}
			return null;
		}

	}

#endif
}
