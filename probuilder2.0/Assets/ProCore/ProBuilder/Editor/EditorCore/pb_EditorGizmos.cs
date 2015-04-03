﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using ProBuilder2.Common;

namespace ProBuilder2.EditorCommon
{

	/**
	 * Renders gizmos to sceneview.
	 */
	public class pb_EditorGizmos : Editor
	{
		const string GIZMO_RENDERER_NAME = "pb_EditorGizmos_gameObject";

		static pb_LineRenderer _renderer;

		~pb_EditorGizmos()
		{

		}

		/**
		 * Iterates a scene looking for gameObjects matching @InName
		 */
		static private void DestroySceneRenderer()
		{
			pb_LineRenderer[] components = (pb_LineRenderer[])Resources.FindObjectsOfTypeAll(typeof(pb_LineRenderer));

			for(int i = 0; i < components.Length; i++)
				DestroyImmediate(_renderer);
		}

		static pb_LineRenderer renderer
		{
			get
			{
				if( _renderer == null )
				 	_renderer = EditorUtility.CreateGameObjectWithHideFlags(GIZMO_RENDERER_NAME, 
				 		pb_Constant.EDITOR_OBJECT_HIDE_FLAGS,
				 		new System.Type[1] { typeof(pb_LineRenderer) }).GetComponent<pb_LineRenderer>();

				return _renderer;
			}
		}

		public static void DrawLineSegments(Vector3[] InWorldPoints, Color[] InColors)
		{
			renderer.AddLineSegments(InWorldPoints, InColors);
		}

	}
}