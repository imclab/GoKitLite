using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class TweenChainingUI : MonoBehaviour
{
	public Transform cube;
	

	void OnGUI()
	{
		GUI.matrix = Matrix4x4.Scale( new Vector3( 2, 2, 2 ) );
		
		if( GUILayout.Button( "Tween Position Queue" ) )
		{
			new GoKitLite.TweenQueue().add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 10, 10, 10 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, -5, -10 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( -3, 5, 20 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.start();
		}


		if( GUILayout.Button( "Tween Position Queue with Delays" ) )
		{
			new GoKitLite.TweenQueue().add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 10, 10, 10 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0.2f, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, -5, -10 ), 0.2f, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( -3, 5, 20 ), 0.2f, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0.2f, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.start();
		}
		
		
		if( GUILayout.Button( "Tween Position and Rotation Queue" ) )
		{
			new GoKitLite.TweenQueue().add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( -8, -3, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.rotationTo( cube, 0.4f, new Vector3( 90f, 0, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 1, 2, -5 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.rotationTo( cube, 0.4f, new Vector3( 0, 90, 90 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.rotationTo( cube, 0.4f, new Vector3( 360, 360, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut, true ); } )
				.setCompletionHandler( () => { Debug.Log( "Position and Rotation Queue Done" ); } )
				.start();
		}
		
		
		if( GUILayout.Button( "Lots of Stuff Queue" ) )
		{
			new GoKitLite.TweenQueue().add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( -8, -3, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.colorTo( cube, 0.3f, Color.red ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 1, 2, -5 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.rotationTo( cube, 0.4f, new Vector3( 0, 90, 90 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.colorTo( cube, 0.3f, Color.yellow ); } )
				.add( () => { return GoKitLite.instance.scaleTo( cube, 0.8f, new Vector3( 3, 3, 3 ), 0, GoKitLiteEasing.Linear.Punch ); } )
				.add( () => { return GoKitLite.instance.positionTo( cube, 0.4f, new Vector3( 0, 0, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut ); } )
				.add( () => { return GoKitLite.instance.colorTo( cube, 0.3f, Color.blue ); } )
				.add( () => { return GoKitLite.instance.rotationTo( cube, 0.4f, new Vector3( 360, 360, 0 ), 0, GoKitLiteEasing.Quadratic.EaseInOut, true ); } )
				.add( () => { return GoKitLite.instance.scaleTo( cube, 0.8f, new Vector3( 4f, 4f, 0.2f ), 0, GoKitLiteEasing.Bounce.EaseOut ).setLoopType( GoKitLite.LoopType.PingPong, 1 ); } )
				.add( () => { return GoKitLite.instance.colorTo( cube, 0.3f, Color.gray ); } )
				.start();
		}

	}
}