import Node, { registerNode } from './Node.js';

class UniformGroupNode extends Node {

	constructor( name, shared = false ) {

		super( 'string' );

		this.name = name;
		this.version = 0;

		this.shared = shared;

		this.isUniformGroup = true;

	}

	set needsUpdate( value ) {

		if ( value === true ) this.version ++;

	}

	serialize( data ) {

		super.serialize( data );

		data.name = this.name;
		data.version = this.version;
		data.shared = this.shared;

	}

	deserialize( data ) {

		super.deserialize( data );

		this.name = data.name;
		this.version = data.version;
		this.shared = data.shared;

	}

}

export default UniformGroupNode;

UniformGroupNode.type = /*@__PURE__*/ registerNode( 'UniformGroup', UniformGroupNode );

export const uniformGroup = ( name ) => new UniformGroupNode( name );
export const sharedUniformGroup = ( name ) => new UniformGroupNode( name, true );

export const frameGroup = /*@__PURE__*/ sharedUniformGroup( 'frame' );
export const renderGroup = /*@__PURE__*/ sharedUniformGroup( 'render' );
export const objectGroup = /*@__PURE__*/ uniformGroup( 'object' );
