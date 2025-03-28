// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;

namespace WebGPU;

public enum WGPUBufferUsage : ulong
{
	None = 0,
	MapRead = 1,
	MapWrite = 2,
	CopySrc = 4,
	CopyDst = 8,
	Index = 16,
	Vertex = 32,
	Uniform = 64,
	Storage = 128,
	Indirect = 256,
	QueryResolve = 512,
}
public enum WGPUColorWriteMask : ulong
{
	None = 0,
	Red = 1,
	Green = 2,
	Blue = 4,
	Alpha = 8,
	All = 15,
}
public enum WGPUMapMode : ulong
{
	None = 0,
	Read = 1,
	Write = 2,
}
public enum WGPUShaderStage : ulong
{
	None = 0,
	Vertex = 1,
	Fragment = 2,
	Compute = 4,
}
public enum WGPUTextureUsage : ulong
{
	None = 0,
	CopySrc = 1,
	CopyDst = 2,
	TextureBinding = 4,
	StorageBinding = 8,
	RenderAttachment = 16,
}
public enum WGPUInstanceBackend : ulong
{
	All = 0,
	Vulkan = 1,
	GL = 2,
	Metal = 4,
	DX12 = 8,
	DX11 = 16,
	BrowserWebGPU = 32,
	Primary = 45,
	Secondary = 18,
	Force32 = 2147483647,
}
public enum WGPUInstanceFlag : ulong
{
	Default = 0,
	Debug = 1,
	Validation = 2,
	DiscardHalLabels = 4,
	Force32 = 2147483647,
}
public enum WGPUAdapterType
{
	None = 0,
	DiscreteGPU = 0x00000001,
	IntegratedGPU = 0x00000002,
	CPU = 0x00000003,
	Unknown = 0x00000004,
}

public enum WGPUAddressMode
{
	None = 0,
	Undefined = 0x00000000,
	ClampToEdge = 0x00000001,
	Repeat = 0x00000002,
	MirrorRepeat = 0x00000003,
}

public enum WGPUBackendType
{
	None = 0,
	Undefined = 0x00000000,
	Null = 0x00000001,
	WebGPU = 0x00000002,
	D3D11 = 0x00000003,
	D3D12 = 0x00000004,
	Metal = 0x00000005,
	Vulkan = 0x00000006,
	OpenGL = 0x00000007,
	OpenGLES = 0x00000008,
}

public enum WGPUBlendFactor
{
	None = 0,
	Undefined = 0x00000000,
	Zero = 0x00000001,
	One = 0x00000002,
	Src = 0x00000003,
	OneMinusSrc = 0x00000004,
	SrcAlpha = 0x00000005,
	OneMinusSrcAlpha = 0x00000006,
	Dst = 0x00000007,
	OneMinusDst = 0x00000008,
	DstAlpha = 0x00000009,
	OneMinusDstAlpha = 0x0000000A,
	SrcAlphaSaturated = 0x0000000B,
	Constant = 0x0000000C,
	OneMinusConstant = 0x0000000D,
	Src1 = 0x0000000E,
	OneMinusSrc1 = 0x0000000F,
	Src1Alpha = 0x00000010,
	OneMinusSrc1Alpha = 0x00000011,
}

public enum WGPUBlendOperation
{
	None = 0,
	Undefined = 0x00000000,
	Add = 0x00000001,
	Subtract = 0x00000002,
	ReverseSubtract = 0x00000003,
	Min = 0x00000004,
	Max = 0x00000005,
}

public enum WGPUBufferBindingType
{
	None = 0,
	BindingNotUsed = 0x00000000,
	Undefined = 0x00000001,
	Uniform = 0x00000002,
	Storage = 0x00000003,
	ReadOnlyStorage = 0x00000004,
}

public enum WGPUBufferMapState
{
	None = 0,
	Unmapped = 0x00000001,
	Pending = 0x00000002,
	Mapped = 0x00000003,
}

public enum WGPUCallbackMode
{
	None = 0,
	WaitAnyOnly = 0x00000001,
	AllowProcessEvents = 0x00000002,
	AllowSpontaneous = 0x00000003,
}

public enum WGPUCompareFunction
{
	None = 0,
	Undefined = 0x00000000,
	Never = 0x00000001,
	Less = 0x00000002,
	Equal = 0x00000003,
	LessEqual = 0x00000004,
	Greater = 0x00000005,
	NotEqual = 0x00000006,
	GreaterEqual = 0x00000007,
	Always = 0x00000008,
}

public enum WGPUCompilationInfoRequestStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	Error = 0x00000003,
	Unknown = 0x00000004,
}

public enum WGPUCompilationMessageType
{
	None = 0,
	Error = 0x00000001,
	Warning = 0x00000002,
	Info = 0x00000003,
}

public enum WGPUCompositeAlphaMode
{
	None = 0,
	Auto = 0x00000000,
	Opaque = 0x00000001,
	Premultiplied = 0x00000002,
	Unpremultiplied = 0x00000003,
	Inherit = 0x00000004,
}

public enum WGPUCreatePipelineAsyncStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	ValidationError = 0x00000003,
	InternalError = 0x00000004,
	Unknown = 0x00000005,
}

public enum WGPUCullMode
{
	Undefined = 0x00000000,
	None = 0x00000001,
	Front = 0x00000002,
	Back = 0x00000003,
}

public enum WGPUDeviceLostReason
{
	None = 0,
	Unknown = 0x00000001,
	Destroyed = 0x00000002,
	InstanceDropped = 0x00000003,
	FailedCreation = 0x00000004,
}

public enum WGPUErrorFilter
{
	None = 0,
	Validation = 0x00000001,
	OutOfMemory = 0x00000002,
	Internal = 0x00000003,
}

public enum WGPUErrorType
{
	None = 0,
	NoError = 0x00000001,
	Validation = 0x00000002,
	OutOfMemory = 0x00000003,
	Internal = 0x00000004,
	Unknown = 0x00000005,
}

public enum WGPUFeatureLevel
{
	None = 0,
	Compatibility = 0x00000001,
	Core = 0x00000002,
}

public enum WGPUFeatureName
{
	None = 0,
	Undefined = 0x00000000,
	DepthClipControl = 0x00000001,
	Depth32FloatStencil8 = 0x00000002,
	TimestampQuery = 0x00000003,
	TextureCompressionBC = 0x00000004,
	TextureCompressionBCSliced3D = 0x00000005,
	TextureCompressionETC2 = 0x00000006,
	TextureCompressionASTC = 0x00000007,
	TextureCompressionASTCSliced3D = 0x00000008,
	IndirectFirstInstance = 0x00000009,
	ShaderF16 = 0x0000000A,
	RG11B10UfloatRenderable = 0x0000000B,
	BGRA8UnormStorage = 0x0000000C,
	Float32Filterable = 0x0000000D,
	Float32Blendable = 0x0000000E,
	ClipDistances = 0x0000000F,
	DualSourceBlending = 0x00000010,
}

public enum WGPUFilterMode
{
	None = 0,
	Undefined = 0x00000000,
	Nearest = 0x00000001,
	Linear = 0x00000002,
}

public enum WGPUFrontFace
{
	None = 0,
	Undefined = 0x00000000,
	CCW = 0x00000001,
	CW = 0x00000002,
}

public enum WGPUIndexFormat
{
	None = 0,
	Undefined = 0x00000000,
	Uint16 = 0x00000001,
	Uint32 = 0x00000002,
}

public enum WGPULoadOp
{
	None = 0,
	Undefined = 0x00000000,
	Load = 0x00000001,
	Clear = 0x00000002,
}

public enum WGPUMapAsyncStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	Error = 0x00000003,
	Aborted = 0x00000004,
	Unknown = 0x00000005,
}

public enum WGPUMipmapFilterMode
{
	None = 0,
	Undefined = 0x00000000,
	Nearest = 0x00000001,
	Linear = 0x00000002,
}

public enum WGPUOptionalBool
{
	None = 0,
	False = 0x00000000,
	True = 0x00000001,
	Undefined = 0x00000002,
}

public enum WGPUPopErrorScopeStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	EmptyStack = 0x00000003,
}

public enum WGPUPowerPreference
{
	None = 0,
	Undefined = 0x00000000,
	LowPower = 0x00000001,
	HighPerformance = 0x00000002,
}

public enum WGPUPresentMode
{
	None = 0,
	Undefined = 0x00000000,
	Fifo = 0x00000001,
	FifoRelaxed = 0x00000002,
	Immediate = 0x00000003,
	Mailbox = 0x00000004,
}

public enum WGPUPrimitiveTopology
{
	None = 0,
	Undefined = 0x00000000,
	PointList = 0x00000001,
	LineList = 0x00000002,
	LineStrip = 0x00000003,
	TriangleList = 0x00000004,
	TriangleStrip = 0x00000005,
}

public enum WGPUQueryType
{
	None = 0,
	Occlusion = 0x00000001,
	Timestamp = 0x00000002,
}

public enum WGPUQueueWorkDoneStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	Error = 0x00000003,
	Unknown = 0x00000004,
}

public enum WGPURequestAdapterStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	Unavailable = 0x00000003,
	Error = 0x00000004,
	Unknown = 0x00000005,
}

public enum WGPURequestDeviceStatus
{
	None = 0,
	Success = 0x00000001,
	InstanceDropped = 0x00000002,
	Error = 0x00000003,
	Unknown = 0x00000004,
}

public enum WGPUSType
{
	None = 0,
	ShaderSourceSPIRV = 0x00000001,
	ShaderSourceWGSL = 0x00000002,
	RenderPassMaxDrawCount = 0x00000003,
	SurfaceSourceMetalLayer = 0x00000004,
	SurfaceSourceWindowsHWND = 0x00000005,
	SurfaceSourceXlibWindow = 0x00000006,
	SurfaceSourceWaylandSurface = 0x00000007,
	SurfaceSourceAndroidNativeWindow = 0x00000008,
	SurfaceSourceXCBWindow = 0x00000009,
}

public enum WGPUSamplerBindingType
{
	None = 0,
	BindingNotUsed = 0x00000000,
	Undefined = 0x00000001,
	Filtering = 0x00000002,
	NonFiltering = 0x00000003,
	Comparison = 0x00000004,
}

public enum WGPUStatus
{
	None = 0,
	Success = 0x00000001,
	Error = 0x00000002,
}

public enum WGPUStencilOperation
{
	None = 0,
	Undefined = 0x00000000,
	Keep = 0x00000001,
	Zero = 0x00000002,
	Replace = 0x00000003,
	Invert = 0x00000004,
	IncrementClamp = 0x00000005,
	DecrementClamp = 0x00000006,
	IncrementWrap = 0x00000007,
	DecrementWrap = 0x00000008,
}

public enum WGPUStorageTextureAccess
{
	None = 0,
	BindingNotUsed = 0x00000000,
	Undefined = 0x00000001,
	WriteOnly = 0x00000002,
	ReadOnly = 0x00000003,
	ReadWrite = 0x00000004,
}

public enum WGPUStoreOp
{
	None = 0,
	Undefined = 0x00000000,
	Store = 0x00000001,
	Discard = 0x00000002,
}

public enum WGPUSurfaceGetCurrentTextureStatus
{
	None = 0,
	SuccessOptimal = 0x00000001,
	SuccessSuboptimal = 0x00000002,
	Timeout = 0x00000003,
	Outdated = 0x00000004,
	Lost = 0x00000005,
	OutOfMemory = 0x00000006,
	DeviceLost = 0x00000007,
	Error = 0x00000008,
}

public enum WGPUTextureAspect
{
	None = 0,
	Undefined = 0x00000000,
	All = 0x00000001,
	StencilOnly = 0x00000002,
	DepthOnly = 0x00000003,
}

public enum WGPUTextureDimension
{
	None = 0,
	Undefined = 0x00000000,
	_1D = 0x00000001,
	_2D = 0x00000002,
	_3D = 0x00000003,
}

public enum WGPUTextureFormat
{
	None = 0,
	Undefined = 0x00000000,
	R8Unorm = 0x00000001,
	R8Snorm = 0x00000002,
	R8Uint = 0x00000003,
	R8Sint = 0x00000004,
	R16Uint = 0x00000005,
	R16Sint = 0x00000006,
	R16Float = 0x00000007,
	RG8Unorm = 0x00000008,
	RG8Snorm = 0x00000009,
	RG8Uint = 0x0000000A,
	RG8Sint = 0x0000000B,
	R32Float = 0x0000000C,
	R32Uint = 0x0000000D,
	R32Sint = 0x0000000E,
	RG16Uint = 0x0000000F,
	RG16Sint = 0x00000010,
	RG16Float = 0x00000011,
	RGBA8Unorm = 0x00000012,
	RGBA8UnormSrgb = 0x00000013,
	RGBA8Snorm = 0x00000014,
	RGBA8Uint = 0x00000015,
	RGBA8Sint = 0x00000016,
	BGRA8Unorm = 0x00000017,
	BGRA8UnormSrgb = 0x00000018,
	RGB10A2Uint = 0x00000019,
	RGB10A2Unorm = 0x0000001A,
	RG11B10Ufloat = 0x0000001B,
	RGB9E5Ufloat = 0x0000001C,
	RG32Float = 0x0000001D,
	RG32Uint = 0x0000001E,
	RG32Sint = 0x0000001F,
	RGBA16Uint = 0x00000020,
	RGBA16Sint = 0x00000021,
	RGBA16Float = 0x00000022,
	RGBA32Float = 0x00000023,
	RGBA32Uint = 0x00000024,
	RGBA32Sint = 0x00000025,
	Stencil8 = 0x00000026,
	Depth16Unorm = 0x00000027,
	Depth24Plus = 0x00000028,
	Depth24PlusStencil8 = 0x00000029,
	Depth32Float = 0x0000002A,
	Depth32FloatStencil8 = 0x0000002B,
	BC1RGBAUnorm = 0x0000002C,
	BC1RGBAUnormSrgb = 0x0000002D,
	BC2RGBAUnorm = 0x0000002E,
	BC2RGBAUnormSrgb = 0x0000002F,
	BC3RGBAUnorm = 0x00000030,
	BC3RGBAUnormSrgb = 0x00000031,
	BC4RUnorm = 0x00000032,
	BC4RSnorm = 0x00000033,
	BC5RGUnorm = 0x00000034,
	BC5RGSnorm = 0x00000035,
	BC6HRGBUfloat = 0x00000036,
	BC6HRGBFloat = 0x00000037,
	BC7RGBAUnorm = 0x00000038,
	BC7RGBAUnormSrgb = 0x00000039,
	ETC2RGB8Unorm = 0x0000003A,
	ETC2RGB8UnormSrgb = 0x0000003B,
	ETC2RGB8A1Unorm = 0x0000003C,
	ETC2RGB8A1UnormSrgb = 0x0000003D,
	ETC2RGBA8Unorm = 0x0000003E,
	ETC2RGBA8UnormSrgb = 0x0000003F,
	EACR11Unorm = 0x00000040,
	EACR11Snorm = 0x00000041,
	EACRG11Unorm = 0x00000042,
	EACRG11Snorm = 0x00000043,
	ASTC4x4Unorm = 0x00000044,
	ASTC4x4UnormSrgb = 0x00000045,
	ASTC5x4Unorm = 0x00000046,
	ASTC5x4UnormSrgb = 0x00000047,
	ASTC5x5Unorm = 0x00000048,
	ASTC5x5UnormSrgb = 0x00000049,
	ASTC6x5Unorm = 0x0000004A,
	ASTC6x5UnormSrgb = 0x0000004B,
	ASTC6x6Unorm = 0x0000004C,
	ASTC6x6UnormSrgb = 0x0000004D,
	ASTC8x5Unorm = 0x0000004E,
	ASTC8x5UnormSrgb = 0x0000004F,
	ASTC8x6Unorm = 0x00000050,
	ASTC8x6UnormSrgb = 0x00000051,
	ASTC8x8Unorm = 0x00000052,
	ASTC8x8UnormSrgb = 0x00000053,
	ASTC10x5Unorm = 0x00000054,
	ASTC10x5UnormSrgb = 0x00000055,
	ASTC10x6Unorm = 0x00000056,
	ASTC10x6UnormSrgb = 0x00000057,
	ASTC10x8Unorm = 0x00000058,
	ASTC10x8UnormSrgb = 0x00000059,
	ASTC10x10Unorm = 0x0000005A,
	ASTC10x10UnormSrgb = 0x0000005B,
	ASTC12x10Unorm = 0x0000005C,
	ASTC12x10UnormSrgb = 0x0000005D,
	ASTC12x12Unorm = 0x0000005E,
	ASTC12x12UnormSrgb = 0x0000005F,
}

public enum WGPUTextureSampleType
{
	None = 0,
	BindingNotUsed = 0x00000000,
	Undefined = 0x00000001,
	Float = 0x00000002,
	UnfilterableFloat = 0x00000003,
	Depth = 0x00000004,
	Sint = 0x00000005,
	Uint = 0x00000006,
}

public enum WGPUTextureViewDimension
{
	None = 0,
	Undefined = 0x00000000,
	_1D = 0x00000001,
	_2D = 0x00000002,
	_2DArray = 0x00000003,
	Cube = 0x00000004,
	CubeArray = 0x00000005,
	_3D = 0x00000006,
}

public enum WGPUVertexFormat
{
	None = 0,
	Uint8 = 0x00000001,
	Uint8x2 = 0x00000002,
	Uint8x4 = 0x00000003,
	Sint8 = 0x00000004,
	Sint8x2 = 0x00000005,
	Sint8x4 = 0x00000006,
	Unorm8 = 0x00000007,
	Unorm8x2 = 0x00000008,
	Unorm8x4 = 0x00000009,
	Snorm8 = 0x0000000A,
	Snorm8x2 = 0x0000000B,
	Snorm8x4 = 0x0000000C,
	Uint16 = 0x0000000D,
	Uint16x2 = 0x0000000E,
	Uint16x4 = 0x0000000F,
	Sint16 = 0x00000010,
	Sint16x2 = 0x00000011,
	Sint16x4 = 0x00000012,
	Unorm16 = 0x00000013,
	Unorm16x2 = 0x00000014,
	Unorm16x4 = 0x00000015,
	Snorm16 = 0x00000016,
	Snorm16x2 = 0x00000017,
	Snorm16x4 = 0x00000018,
	Float16 = 0x00000019,
	Float16x2 = 0x0000001A,
	Float16x4 = 0x0000001B,
	Float32 = 0x0000001C,
	Float32x2 = 0x0000001D,
	Float32x3 = 0x0000001E,
	Float32x4 = 0x0000001F,
	Uint32 = 0x00000020,
	Uint32x2 = 0x00000021,
	Uint32x3 = 0x00000022,
	Uint32x4 = 0x00000023,
	Sint32 = 0x00000024,
	Sint32x2 = 0x00000025,
	Sint32x3 = 0x00000026,
	Sint32x4 = 0x00000027,
	Unorm1010102 = 0x00000028,
	Unorm8x4BGRA = 0x00000029,
}

public enum WGPUVertexStepMode
{
	None = 0,
	VertexBufferNotUsed = 0x00000000,
	Undefined = 0x00000001,
	Vertex = 0x00000002,
	Instance = 0x00000003,
}

public enum WGPUWGSLLanguageFeatureName
{
	None = 0,
	ReadonlyAndReadwriteStorageTextures = 0x00000001,
	Packed4x8IntegerDotProduct = 0x00000002,
	UnrestrictedPointerParameters = 0x00000003,
	PointerCompositeAccess = 0x00000004,
}

public enum WGPUWaitStatus
{
	None = 0,
	Success = 0x00000001,
	TimedOut = 0x00000002,
	UnsupportedTimeout = 0x00000003,
	UnsupportedCount = 0x00000004,
	UnsupportedMixedSources = 0x00000005,
}

public enum WGPUNativeSType
{
	None = 0,
	DeviceExtras = 0x00030001,
	NativeLimits = 0x00030002,
	PipelineLayoutExtras = 0x00030003,
	ShaderModuleGLSLDescriptor = 0x00030004,
	InstanceExtras = 0x00030006,
	BindGroupEntryExtras = 0x00030007,
	BindGroupLayoutEntryExtras = 0x00030008,
	QuerySetDescriptorExtras = 0x00030009,
	SurfaceConfigurationExtras = 0x0003000A,
}

public enum WGPUNativeFeature
{
	None = 0,
	PushConstants = 0x00030001,
	TextureAdapterSpecificFormatFeatures = 0x00030002,
	MultiDrawIndirect = 0x00030003,
	MultiDrawIndirectCount = 0x00030004,
	VertexWritableStorage = 0x00030005,
	TextureBindingArray = 0x00030006,
	SampledTextureAndStorageBufferArrayNonUniformIndexing = 0x00030007,
	PipelineStatisticsQuery = 0x00030008,
	StorageResourceBindingArray = 0x00030009,
	PartiallyBoundBindingArray = 0x0003000A,
	TextureFormat16bitNorm = 0x0003000B,
	TextureCompressionAstcHdr = 0x0003000C,
	MappablePrimaryBuffers = 0x0003000E,
	BufferBindingArray = 0x0003000F,
	UniformBufferAndStorageTextureArrayNonUniformIndexing = 0x00030010,
	SpirvShaderPassthrough = 0x00030017,
	VertexAttribute64bit = 0x00030019,
	TextureFormatNv12 = 0x0003001A,
	RayTracingAccelerationStructure = 0x0003001B,
	RayQuery = 0x0003001C,
	ShaderF64 = 0x0003001D,
	ShaderI16 = 0x0003001E,
	ShaderPrimitiveIndex = 0x0003001F,
	ShaderEarlyDepthTest = 0x00030020,
	Subgroup = 0x00030021,
	SubgroupVertex = 0x00030022,
	SubgroupBarrier = 0x00030023,
	TimestampQueryInsideEncoders = 0x00030024,
	TimestampQueryInsidePasses = 0x00030025,
}

public enum WGPULogLevel
{
	None = 0,
	Off = 0x00000000,
	Error = 0x00000001,
	Warn = 0x00000002,
	Info = 0x00000003,
	Debug = 0x00000004,
	Trace = 0x00000005,
}

public enum WGPUDx12Compiler
{
	None = 0,
	Undefined = 0x00000000,
	Fxc = 0x00000001,
	Dxc = 0x00000002,
}

public enum WGPUGles3MinorVersion
{
	None = 0,
	Automatic = 0x00000000,
	Version0 = 0x00000001,
	Version1 = 0x00000002,
	Version2 = 0x00000003,
}

public enum WGPUPipelineStatisticName
{
	None = 0,
	VertexShaderInvocations = 0x00000000,
	ClipperInvocations = 0x00000001,
	ClipperPrimitivesOut = 0x00000002,
	FragmentShaderInvocations = 0x00000003,
	ComputeShaderInvocations = 0x00000004,
}

public enum WGPUNativeQueryType
{
	None = 0,
	PipelineStatistics = 0x00030000,
}

public enum WGPUNativeTextureFormat
{
	None = 0,
	R16Unorm = 0x00030001,
	R16Snorm = 0x00030002,
	Rg16Unorm = 0x00030003,
	Rg16Snorm = 0x00030004,
	Rgba16Unorm = 0x00030005,
	Rgba16Snorm = 0x00030006,
	NV12 = 0x00030007,
}

