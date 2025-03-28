// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Runtime.InteropServices;

namespace MeshOptimizer;

public unsafe partial class Meshopt
{
	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateVertexRemap")]
	public static partial nuint GenerateVertexRemap(uint* destination, uint* indices, nuint index_count, void* vertices, nuint vertex_count, nuint vertex_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateVertexRemapMulti")]
	public static partial nuint GenerateVertexRemapMulti(uint* destination, uint* indices, nuint index_count, nuint vertex_count, Stream* streams, nuint stream_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_remapVertexBuffer")]
	public static partial void RemapVertexBuffer(void* destination, void* vertices, nuint vertex_count, nuint vertex_size, uint* remap);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_remapIndexBuffer")]
	public static partial void RemapIndexBuffer(uint* destination, uint* indices, nuint index_count, uint* remap);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateShadowIndexBuffer")]
	public static partial void GenerateShadowIndexBuffer(uint* destination, uint* indices, nuint index_count, void* vertices, nuint vertex_count, nuint vertex_size, nuint vertex_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateShadowIndexBufferMulti")]
	public static partial void GenerateShadowIndexBufferMulti(uint* destination, uint* indices, nuint index_count, nuint vertex_count, Stream* streams, nuint stream_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateAdjacencyIndexBuffer")]
	public static partial void GenerateAdjacencyIndexBuffer(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateTessellationIndexBuffer")]
	public static partial void GenerateTessellationIndexBuffer(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_generateProvokingIndexBuffer")]
	public static partial nuint GenerateProvokingIndexBuffer(uint* destination, uint* reorder, uint* indices, nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeVertexCache")]
	public static partial void OptimizeVertexCache(uint* destination, uint* indices, nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeVertexCacheStrip")]
	public static partial void OptimizeVertexCacheStrip(uint* destination, uint* indices, nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeVertexCacheFifo")]
	public static partial void OptimizeVertexCacheFifo(uint* destination, uint* indices, nuint index_count, nuint vertex_count, uint cache_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeOverdraw")]
	public static partial void OptimizeOverdraw(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, float threshold);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeVertexFetch")]
	public static partial nuint OptimizeVertexFetch(void* destination, uint* indices, nuint index_count, void* vertices, nuint vertex_count, nuint vertex_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeVertexFetchRemap")]
	public static partial nuint OptimizeVertexFetchRemap(uint* destination, uint* indices, nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeIndexBuffer")]
	public static partial nuint EncodeIndexBuffer(byte* buffer, nuint buffer_size, uint* indices, nuint index_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeIndexBufferBound")]
	public static partial nuint EncodeIndexBufferBound(nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeIndexVersion")]
	public static partial void EncodeIndexVersion(int version);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeIndexBuffer")]
	public static partial int DecodeIndexBuffer(void* destination, nuint index_count, nuint index_size, byte* buffer, nuint buffer_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeIndexSequence")]
	public static partial nuint EncodeIndexSequence(byte* buffer, nuint buffer_size, uint* indices, nuint index_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeIndexSequenceBound")]
	public static partial nuint EncodeIndexSequenceBound(nuint index_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeIndexSequence")]
	public static partial int DecodeIndexSequence(void* destination, nuint index_count, nuint index_size, byte* buffer, nuint buffer_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeVertexBuffer")]
	public static partial nuint EncodeVertexBuffer(byte* buffer, nuint buffer_size, void* vertices, nuint vertex_count, nuint vertex_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeVertexBufferBound")]
	public static partial nuint EncodeVertexBufferBound(nuint vertex_count, nuint vertex_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeVertexBufferLevel")]
	public static partial nuint EncodeVertexBufferLevel(byte* buffer, nuint buffer_size, void* vertices, nuint vertex_count, nuint vertex_size, int level);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeVertexVersion")]
	public static partial void EncodeVertexVersion(int version);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeVertexBuffer")]
	public static partial int DecodeVertexBuffer(void* destination, nuint vertex_count, nuint vertex_size, byte* buffer, nuint buffer_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeFilterOct")]
	public static partial void DecodeFilterOct(void* buffer, nuint count, nuint stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeFilterQuat")]
	public static partial void DecodeFilterQuat(void* buffer, nuint count, nuint stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_decodeFilterExp")]
	public static partial void DecodeFilterExp(void* buffer, nuint count, nuint stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeFilterOct")]
	public static partial void EncodeFilterOct(void* destination, nuint count, nuint stride, int bits, float* data);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeFilterQuat")]
	public static partial void EncodeFilterQuat(void* destination, nuint count, nuint stride, int bits, float* data);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_encodeFilterExp")]
	public static partial void EncodeFilterExp(void* destination, nuint count, nuint stride, int bits, float* data, EncodeExpMode mode);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_simplify")]
	public static partial nuint Simplify(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, nuint target_index_count, float target_error, SimplificationOptions options, float* result_error);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_simplifyWithAttributes")]
	public static partial nuint SimplifyWithAttributes(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, float* vertex_attributes, nuint vertex_attributes_stride, float* attribute_weights, nuint attribute_count, byte* vertex_lock, nuint target_index_count, float target_error, SimplificationOptions options, float* result_error);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_simplifySloppy")]
	public static partial nuint SimplifySloppy(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, nuint target_index_count, float target_error, float* result_error);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_simplifyPoints")]
	public static partial nuint SimplifyPoints(uint* destination, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, float* vertex_colors, nuint vertex_colors_stride, float color_weight, nuint target_vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_simplifyScale")]
	public static partial float SimplifyScale(float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_stripify")]
	public static partial nuint Stripify(uint* destination, uint* indices, nuint index_count, nuint vertex_count, uint restart_index);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_stripifyBound")]
	public static partial nuint StripifyBound(nuint index_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_unstripify")]
	public static partial nuint Unstripify(uint* destination, uint* indices, nuint index_count, uint restart_index);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_unstripifyBound")]
	public static partial nuint UnstripifyBound(nuint index_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_analyzeVertexCache")]
	public static partial VertexCacheStatistics AnalyzeVertexCache(uint* indices, nuint index_count, nuint vertex_count, uint cache_size, uint warp_size, uint primgroup_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_analyzeOverdraw")]
	public static partial OverdrawStatistics AnalyzeOverdraw(uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_analyzeVertexFetch")]
	public static partial VertexFetchStatistics AnalyzeVertexFetch(uint* indices, nuint index_count, nuint vertex_count, nuint vertex_size);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_buildMeshlets")]
	public static partial nuint BuildMeshlets(Meshlet* meshlets, uint* meshlet_vertices, byte* meshlet_triangles, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride, nuint max_vertices, nuint max_triangles, float cone_weight);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_buildMeshletsScan")]
	public static partial nuint BuildMeshletsScan(Meshlet* meshlets, uint* meshlet_vertices, byte* meshlet_triangles, uint* indices, nuint index_count, nuint vertex_count, nuint max_vertices, nuint max_triangles);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_buildMeshletsBound")]
	public static partial nuint BuildMeshletsBound(nuint index_count, nuint max_vertices, nuint max_triangles);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_optimizeMeshlet")]
	public static partial void OptimizeMeshlet(uint* meshlet_vertices, byte* meshlet_triangles, nuint triangle_count, nuint vertex_count);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_computeClusterBounds")]
	public static partial Bounds ComputeClusterBounds(uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_computeMeshletBounds")]
	public static partial Bounds ComputeMeshletBounds(uint* meshlet_vertices, byte* meshlet_triangles, nuint triangle_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_spatialSortRemap")]
	public static partial void SpatialSortRemap(uint* destination, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_spatialSortTriangles")]
	public static partial void SpatialSortTriangles(uint* destination, uint* indices, nuint index_count, float* vertex_positions, nuint vertex_count, nuint vertex_positions_stride);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_quantizeHalf")]
	public static partial ushort QuantizeHalf(float v);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_quantizeFloat")]
	public static partial float QuantizeFloat(float v, int N);

	[LibraryImport(LibraryName, EntryPoint = "meshopt_dequantizeHalf")]
	public static partial float DequantizeHalf(ushort h);

}
